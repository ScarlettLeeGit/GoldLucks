
window.onload = function(){
	document.addEventListener('tizenhwkey',function(e){
		var activePageId = $.mobile.activePage.attr('id');
		if(e.keyName==='back'){
				if(activePageId==='page1'||activePageId==='page2'){
					$.mobile.changePage('#home');
				}else{
					history.back();
				}
		}
	});
};

$('#fixed').on('pagebeforeshow',function beforeshow(){
	var date = new Date(),
		startTime = date.getHours()+':'+date.getMinutes();
	alert('hi');
	$('#startTime').val(startTime);
});
