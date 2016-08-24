#include "goldlucks.h"

static Evas_Object*
create_button_view(Evas_Object *parent, Evas_Object *nf){
	Evas_Object *btn, *img, *box;

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box,EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box,EVAS_HINT_FILL,EVAS_HINT_FILL);


	/*icon_reorder style*/
	btn = elm_button_add(box);
	elm_object_style_set(btn,"icon_reorder");
	evas_object_smart_callback_add(btn,"clicked",btn_back_cb,nf);
	evas_object_show(btn);
	elm_box_pack_end(box,btn);

	return box;
}

void
expense_view_cb(void *data,Evas_Object *obj, void *event_info){
	Evas_Object *scroller, *layout,*btn;
	Evas_Object *nf = data;
	Elm_Object_Item *nf_it;

	evas_object_del(obj);
	obj = NULL;


	scroller = elm_scroller_add(nf);
	layout = create_button_view(scroller,nf);
	//layout = create_button_view(scroller);
	elm_object_content_set(scroller,layout);

	nf_it = elm_naviframe_item_push(nf,"EXPENSE",NULL,NULL,scroller,NULL);

	/**/
	btn = elm_button_add(nf);
	elm_object_style_set(btn, "naviframe/title_cancel");
	evas_object_smart_callback_add(btn, "clicked", btn_back_cb, nf);
	elm_object_item_part_content_set(nf_it, "title_left_btn", btn);

	/**/
	btn = elm_button_add(nf);
	elm_object_style_set(btn, "naviframe/title_done");
	evas_object_smart_callback_add(btn, "clicked", btn_back_cb, nf);
	elm_object_item_part_content_set(nf_it, "title_right_btn", btn);
}
