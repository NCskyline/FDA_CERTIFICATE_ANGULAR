$(document).ready(function(){
	$(".card.aco .hc").click(function(){
		if($(this).parent().hasClass("active")){
			$(this).parent().removeClass("active");
		}else{
			$(this).parent().addClass("active");
		}
	});
});