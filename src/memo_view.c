#include "goldlucks.h"
typedef struct item_data{
	int index;
	Elm_Object_Item *item;
}item_data_s;

typedef struct{
	Evas_Object *naviframe;
	Elm_Object_Item *naviframe_item;

	Evas_Object			*start_datetime;
	Evas_Object *layout;
	Evas_Object *genlist;
	Evas_Object			*start_date_btn;
	Evas_Object			*date_time_popup;

	char *title_entry;
	char *description_entry;

	Elm_Object_Item *genlist_description_item;
	Elm_Object_Item		*genlist_from_item;

	struct tm			stm;

}create_view_data;


enum _ENTRY_TYPE {
    TITLE_ENTRY,
    LOCATION_ENTRY,
    DESCRIPTION_ENTRY
};
typedef enum _ENTRY_TYPE ENTRY_TYPE;
/*these were in the config.h*/
static const char *TITLE                = "Title";
static const char *TITLE_HINT           = "Enter the title";
static const char *DESCRIPTION          = "Description";
static const char *DESCRIPTION_HINT     = "Enter the description";
static const char *FROM                 = "From";
static const char *CANCEL				= "Cancel";
static const char *SET					= "Set";
#define FORMAT_BUFFER                   128
#define LABEL_FORMAT                    "<p font_size=%d>%s</p>"
#define ENTRY_LABEL_FORMAT              "<p color=#000 font_size=%d>%s</p>"
#define STYLE_FORMAT                    "DEFAULT='font_size=%d'"
#define DATE_TIME_BUF_LEN               64
#define ENTRY_SPACER_WIDTH              32
#define ENTRY_MIN_HEIGHT                140
#define BUTTON_DATE_WIDTH               240
#define BUTTON_HEIGHT                   80
#define BOX_PADDING                     10

#define ELM_ENTRY_MIN_HEIGHT ELM_SCALE_SIZE(ENTRY_MIN_HEIGHT)
#define ELM_ENTRY_SPACER_WIDTH ELM_SCALE_SIZE(ENTRY_SPACER_WIDTH)
#define ELM_BOX_PADDING ELM_SCALE_SIZE(BOX_PADDING)
#define ELM_BUTTON_HEIGHT ELM_SCALE_SIZE(BUTTON_HEIGHT)
#define ELM_BUTTON_DATE_WIDTH ELM_SCALE_SIZE(BUTTON_DATE_WIDTH)
#define ELM_BOX_PADDING ELM_SCALE_SIZE(BOX_PADDING)
#define TEXT_ITEM_DEFAULT_SIZE          40
#define TEXT_MAX_GOOD_SIZE              60
#define SUBJECT_CHAR_LIMIT              100
#define SUBJECT_BYTE_LIMIT              256

#define TM_START_YEAR                   1900
#define TM_START_MONTH                  1
#define MONTHS                          12

const int get_system_font_size()
{
	int fontSize = 0;
	Eina_Bool res = edje_text_class_get("entry", NULL, &fontSize);
	if (!res){
		fontSize = TEXT_ITEM_DEFAULT_SIZE;
	}
	else if (fontSize < 0){
		fontSize = -fontSize * TEXT_ITEM_DEFAULT_SIZE / 100;
	}

	if (fontSize > TEXT_MAX_GOOD_SIZE){
		fontSize = TEXT_MAX_GOOD_SIZE;
	}

	return fontSize;
}

static bool _close_active_popup(create_view_data *view_data)
{
	//RETVM_IF(!view_data, false, "view_data is NULL");

//	if (view_data->reminder_ctxpopup) {
//		evas_object_del(view_data->reminder_ctxpopup);
//		view_data->reminder_ctxpopup = NULL;
//	} else if (view_data->sensitivity_ctxpopup) {
//		evas_object_del(view_data->sensitivity_ctxpopup);
//		view_data->sensitivity_ctxpopup = NULL;
//	} else if (view_data->priority_ctxpopup) {
//		evas_object_del(view_data->priority_ctxpopup);
//		view_data->priority_ctxpopup = NULL;
//	} else if (view_data->status_ctxpopup) {
//		evas_object_del(view_data->status_ctxpopup);
//		view_data->status_ctxpopup = NULL;
//	} else if (view_data->popup) {
//		evas_object_del(view_data->popup);
//		view_data->popup = NULL;
//	} else if (view_data->date_time_popup) {
//		Evas_Object *obj = elm_object_content_get(view_data->date_time_popup);
//		elm_object_content_unset(view_data->date_time_popup);
//		evas_object_hide(obj);
//		evas_object_del(view_data->date_time_popup);
//		view_data->date_time_popup = NULL;
//	} else {
//		return false;
//	}

	if (view_data->date_time_popup) {
		Evas_Object *obj = elm_object_content_get(view_data->date_time_popup);
		elm_object_content_unset(view_data->date_time_popup);
		evas_object_hide(obj);
		evas_object_del(view_data->date_time_popup);
		view_data->date_time_popup = NULL;
	} else {
		return false;
	}
	return true;
}


static Evas_Object *_prepare_entry_box (create_view_data *item_data, const char *name, const char *hint, Evas_Smart_Cb func){
	create_view_data *data = (create_view_data *)item_data;

	Evas_Object *box = elm_box_add(data->genlist);
	elm_box_horizontal_set(box, EINA_TRUE);
	evas_object_size_hint_min_set(box,0,ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(box);

	Evas_Object *rect1 = evas_object_rectangle_add(box);
	evas_object_color_set(rect1,0,0,0,0);
	evas_object_size_hint_min_set(rect1,ELM_ENTRY_SPACER_WIDTH,ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(rect1);

	Evas_Object *rect2 = evas_object_rectangle_add(box);
	evas_object_color_set(rect2,0,0,0,0);
	evas_object_size_hint_min_set(rect2,ELM_ENTRY_SPACER_WIDTH,ELM_ENTRY_MIN_HEIGHT);
	evas_object_show(rect2);

	Evas_Object *label = elm_label_add(box);
	char buffer [FORMAT_BUFFER]={0};
	snprintf(buffer,sizeof(buffer)-1,ENTRY_LABEL_FORMAT,get_system_font_size(),name);
	elm_object_text_set(label, buffer);
	evas_object_show(label);

	Evas_Object *entry = elm_entry_add(box);
	elm_entry_single_line_set(entry,EINA_FALSE);
	elm_entry_scrollable_set(entry,EINA_TRUE);
	elm_scroller_policy_set(entry,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);
	snprintf(buffer,sizeof(buffer)-1,STYLE_FORMAT,get_system_font_size());
	elm_entry_text_style_user_push(entry,buffer);
	Elm_Entry_Filter_Limit_Size limit = {SUBJECT_CHAR_LIMIT,SUBJECT_BYTE_LIMIT};
	elm_entry_markup_filter_append(entry,elm_entry_filter_limit_size,&limit);
	elm_entry_cursor_end_set(entry);
	elm_entry_cnp_mode_set(entry,ELM_CNP_MODE_PLAINTEXT);

	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry,EVAS_HINT_FILL,EVAS_HINT_FILL);

	snprintf(buffer,sizeof(buffer)-1,LABEL_FORMAT,get_system_font_size(),hint);
	elm_object_part_text_set(entry,"elm.guide",buffer);
	evas_object_smart_callback_add(entry,"changed",func,data);
	evas_object_show(entry);

	elm_box_pack_end(box,rect1);
	elm_box_pack_end(box,label);
	elm_box_pack_end(box,rect2);
	elm_box_pack_end(box,entry);

	return box;

}

static void _title_entry_changed_cb(void *data,Evas_Object *obj,void *event_info){
	create_view_data *ad = (create_view_data *)data;
	if(ad->title_entry != NULL){
		free(ad->title_entry);
		ad->title_entry=NULL;
	}
	ad->title_entry = strdup(elm_entry_entry_get(obj));
}

static void _description_entry_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	if (ad->description_entry != NULL) {
		free(ad->description_entry);
		ad->description_entry = NULL;
	}
	ad->description_entry = strdup(elm_entry_entry_get(obj));
}

static Evas_Object *_entry_add(create_view_data *data, ENTRY_TYPE entry_type){
	Evas_Object *box = NULL;
	switch(entry_type){
	case TITLE_ENTRY:
		box = _prepare_entry_box(data,TITLE,TITLE_HINT,_title_entry_changed_cb);
		break;
	case DESCRIPTION_ENTRY:
		box = _prepare_entry_box(data, DESCRIPTION, DESCRIPTION_HINT,_description_entry_changed_cb);
		break;
	}

	return box;
}

Evas_Object *ui_utils_create_genlist(Evas_Object *parent)
{
	Evas_Object *gen_list = elm_genlist_add(parent);
	elm_genlist_mode_set(gen_list, ELM_LIST_COMPRESS);

	return gen_list;
}

Evas_Object *ui_utils_layout_add(Evas_Object *parent, Evas_Object_Event_Cb destroy_cb, void *cb_data)
{
	Evas_Object *layout = elm_layout_add(parent);

	elm_layout_theme_set(layout, "layout", "application", "default");
	evas_object_event_callback_add(layout, EVAS_CALLBACK_FREE, destroy_cb, cb_data);

	return layout;
}

static char *_start_datetime_label_cb(void *data, Evas_Object *obj, const char *part)
{
	char buffer[FORMAT_BUFFER] = {0};
	snprintf(buffer, sizeof(buffer) - 1, LABEL_FORMAT, get_system_font_size(), FROM);
	return strdup(buffer);
}

static Evas_Object *_date_time_popup_add(Evas_Object *parent, create_view_data *view,
										Evas_Smart_Cb set_cb, Evas_Smart_Cb cancel_cb)
{
	Evas_Object *popup = elm_popup_add(parent);
	view->date_time_popup = popup;

	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_CENTER);
	evas_object_show(popup);

	Evas_Object *cancel_btn = elm_button_add(popup);
	elm_object_style_set(cancel_btn, "popup");
	elm_object_text_set(cancel_btn, CANCEL);
	elm_object_part_content_set(popup, "button1", cancel_btn);
	evas_object_smart_callback_add(cancel_btn, "clicked", cancel_cb, view);

	Evas_Object *set_btn = elm_button_add(popup);
	elm_object_style_set(set_btn, "popup");
	elm_object_text_set(set_btn, SET);
	elm_object_part_content_set(popup, "button2", set_btn);
	evas_object_smart_callback_add(set_btn, "clicked", set_cb, view);

	return popup;
}
////////////
static void _on_datetime_popup_set_cb(void *data, Evas_Object *obj, void *event_info)
{
	//RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;

	Elm_Object_Item *selected_item = elm_genlist_selected_item_get(view->genlist);

	if (selected_item == view->genlist_from_item) {
		elm_datetime_value_get(view->start_datetime, &view->stm);
		_close_active_popup(view);
	} /*else if (selected_item == view->genlist_to_item) {
		elm_datetime_value_get(view->end_datetime, &view->etm);
		_close_active_popup(view);
	}*/
	elm_genlist_item_update(selected_item);
}


static void _on_datetime_popup_cancel_cb(void *data, Evas_Object *obj, void *event_info)
{
	//RETM_IF(!data, "data is null");
	create_view_data *view = data;

	_close_active_popup(view);
}


static void _get_start_datetime(create_view_data *view, Evas_Object *parent, const char *format)
{
	if (!view->start_datetime) {
		view->start_datetime = elm_datetime_add(parent);
		evas_object_size_hint_weight_set(view->start_datetime, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(view->start_datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	}

	elm_datetime_value_set(view->start_datetime, &view->stm);
	elm_datetime_format_set(view->start_datetime, format);
	evas_object_show(view->start_datetime);
}


static void _start_date_btn_cb(void *data, Evas_Object* obj, void *event_info)
{
	//RETM_IF(!data, "data is null");
	create_view_data *view = (create_view_data *)data;
//Cb들 해결할것
	//Evas_Object *popup = _date_time_popup_add(view->win->win, view, _on_datetime_popup_set_cb, _on_datetime_popup_cancel_cb);
	//그냥 네비프레임으로해보자->됨
	Evas_Object *popup = _date_time_popup_add(view->naviframe, view, _on_datetime_popup_set_cb,_on_datetime_popup_cancel_cb);
	evas_object_show(popup);

	_get_start_datetime(view, popup, "%d %b %Y");

	elm_object_content_set(popup, view->start_datetime);
}

static Evas_Object *_start_datetime_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	//RETVM_IF(!item_data, NULL, "Passed NULL input data");
	create_view_data *data = (create_view_data *)item_data;

	if (strcmp(part, "elm.swallow.end") == 0) {
		Evas_Object *box = elm_box_add(obj);
		elm_box_horizontal_set(box, EINA_TRUE);
		elm_box_padding_set(box, ELM_BOX_PADDING, ELM_BOX_PADDING);
		elm_box_align_set(box, 0.0, 0.5);
		evas_object_show(box);

		data->start_date_btn = elm_button_add(box);
		evas_object_show(data->start_date_btn);
		evas_object_smart_callback_add(data->start_date_btn, "clicked", _start_date_btn_cb, data);

		char buf[DATE_TIME_BUF_LEN] = {0};
		strftime(buf, DATE_TIME_BUF_LEN, "%x", &data->stm);
		elm_object_text_set(data->start_date_btn, buf);

		evas_object_size_hint_weight_set(data->start_date_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		evas_object_size_hint_min_set(data->start_date_btn, ELM_BUTTON_DATE_WIDTH, ELM_BUTTON_HEIGHT);
		elm_box_pack_end(box, data->start_date_btn);

		//우리는 start_time은 필요가 없으니까
//		if (!data->is_allday) {
//			data->start_time_btn = elm_button_add(box);
//			evas_object_show(data->start_time_btn);
//			evas_object_smart_callback_add(data->start_time_btn, "clicked", _start_time_btn_cb, data);
//
//			strftime(buf, DATE_TIME_BUF_LEN, "%R", &data->stm);
//			elm_object_text_set(data->start_time_btn, buf);
//			evas_object_size_hint_weight_set(data->start_time_btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//			evas_object_size_hint_min_set(data->start_time_btn, ELM_BUTTON_TIME_WIDTH, ELM_BUTTON_HEIGHT);
//			elm_box_pack_end(box, data->start_time_btn);
//		}

		return box;
	}

	return NULL;
}

static Evas_Object *_title_content_cb(void *item_data,Evas_Object *obj, const char *part){
	//Evas_Object *nf = (Evas_Object *)item_data;

	create_view_data * data = (create_view_data*)item_data;

	return _entry_add(data,TITLE_ENTRY);

}

static Evas_Object *_description_content_cb(void *item_data, Evas_Object *obj, const char *part)
{
	create_view_data *data = (create_view_data *)item_data;

	return _entry_add(data, DESCRIPTION_ENTRY);
}

static void genlist_items_append(create_view_data *data){

	static Elm_Genlist_Item_Class itc_from = {
		.item_style = "default",
		.func.text_get = _start_datetime_label_cb,
		.func.content_get = _start_datetime_content_cb,
	};
	static Elm_Genlist_Item_Class itc_title = {
		.item_style = "full",
		.func.content_get = _title_content_cb,
	};

	static Elm_Genlist_Item_Class itc_description = {
		.item_style = "full",
		.func.content_get = _description_content_cb,
	};

	data->genlist_from_item =
			elm_genlist_item_append(data->genlist, &itc_from, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);
	elm_genlist_item_append(data->genlist, &itc_title, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);
	data->genlist_description_item =
			elm_genlist_item_append(data->genlist, &itc_description, data, NULL, ELM_GENLIST_ITEM_NONE, NULL, data);

}

static void genlist_add(create_view_data *data){
	data->genlist = ui_utils_create_genlist(data->layout);
	elm_layout_theme_set(data->layout, "layout", "application", "default");
	elm_genlist_select_mode_set(data->genlist, ELM_OBJECT_SELECT_MODE_ALWAYS);
	elm_genlist_highlight_mode_set(data->genlist, EINA_FALSE);
	evas_object_size_hint_weight_set(data->genlist, EVAS_HINT_EXPAND,
			EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->genlist, EVAS_HINT_FILL,
			EVAS_HINT_FILL);
	elm_scroller_policy_set(data->genlist, ELM_SCROLLER_POLICY_OFF,
			ELM_SCROLLER_POLICY_AUTO);
	elm_object_part_content_set(data->layout, "elm.swallow.content",
			data->genlist);
	evas_object_show(data->genlist);
}

static void _create_view_destroy_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	create_view_data *ad = (create_view_data *)data;
	free(ad->title_entry);
	free(ad->description_entry);
	free(data);
}

void
memo_view_cb(void *nf, Evas_Object *obj, void *event_info){
	Evas_Object *btn,*label,*box;

	create_view_data *data = calloc(1, sizeof(create_view_data));
	time_t time_now = time(0);
	data->naviframe = nf;
	data->layout = ui_utils_layout_add(data->naviframe, _create_view_destroy_cb, data);

	/*delete ctxpopup*/
	evas_object_del(obj);
	obj = NULL;

	/* Set current time */
	struct tm *loc_tm = localtime(&time_now);
	if (loc_tm) {
		data->stm = *loc_tm;
	}
	/* Setting layout properties */
	evas_object_size_hint_weight_set(data->layout, EVAS_HINT_EXPAND,
			EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(data->layout, EVAS_HINT_FILL,
			EVAS_HINT_FILL);
	//elm_layout_file_set(data->layout, GET_PATH(EDJ_NAME), "create_view_layout");

	data->naviframe_item = elm_naviframe_item_push(data->naviframe,"Schedule MEMO",NULL,NULL,data->layout,NULL);


	/**/
	btn = elm_button_add(data->naviframe);
	elm_object_style_set(btn, "naviframe/title_cancel");
	evas_object_smart_callback_add(btn, "clicked", btn_back_cb, data->naviframe);
	elm_object_item_part_content_set(data->naviframe_item, "title_left_btn", btn);

	/**/
	btn = elm_button_add(data->naviframe);
	elm_object_style_set(btn, "naviframe/title_done");
	evas_object_smart_callback_add(btn, "clicked", btn_back_cb, data->naviframe);
	elm_object_item_part_content_set(data->naviframe_item, "title_right_btn", btn);

	//box = elm_box_add(scroller);
//	box = elm_box_add(data->layout);
//	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	elm_object_content_set(data->layout,box);
//
//	/*icon_reorder style*/
//	btn = elm_button_add(box);
//	elm_object_style_set(btn, "icon_reorder");
//	evas_object_smart_callback_add(btn, "clicked", btn_back_cb, data->naviframe);
//	evas_object_show(btn);
//	elm_box_pack_end(box, btn);
//
//	/*Label*/
//	label = elm_label_add(box);
//	elm_object_text_set(label, "<align=center>Title</align>");
//	evas_object_size_hint_weight_set(label, EVAS_HINT_EXPAND, 0);
//	evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	evas_object_show(label);
//	elm_box_pack_end(box, label);
//
//	/*Bg-1*/
//	Evas_Object *bg = elm_bg_add(box);
//	elm_bg_color_set(bg,170,220,255);
//	evas_object_size_hint_weight_set(bg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	evas_object_size_hint_align_set(bg, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	evas_object_show(bg);
//	elm_box_pack_end(box,bg);
//
//
//	/*Entry-1*/
//	Evas_Object *entry = elm_entry_add(box);
//	//elm_entry_multiple_line_set(entry,EINA_TRUE);
//	elm_object_part_text_set(entry, "elm.guide", "Input Title");
//	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
//	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
//	evas_object_show(entry);
//	elm_box_pack_end(box, entry);

	/* Create genlist for Events control */
	genlist_add(data);
	genlist_items_append(data);

}
