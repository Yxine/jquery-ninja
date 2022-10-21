var Ninja = {

	News: {

		Page: 1,

		More: function (page) {
			Ninja.News.Page = page == null ? Ninja.News.Page : 0;
			$.get(
				'/news/more/' + Ninja.News.Page,
				function (data) {
					data = $.trim(data);
					if (data === '') {
						$('button').hide();
					} else {
						$('.news').append(data);
						Ninja.News.Page++;
					}
				}
			);
		}

	}

};

window.onload = function () {
	console.log('Event: window.onload');
};

$(function () {

	console.log('Event: jQuery load');

	var clicked = false;
	$('[data-action="more-news"]').click(
		function () {
			if (clicked) return false;
			clicked = true;
			Ninja.News.More(null);
			clicked = false;
		}
	);

	if ($('[data-action="lazy-load"]').length === 1) {
		setTimeout(
			function () {
				Ninja.News.More(0);
				$('.news, button').show();
			},
			10000
		);
	}

	/*
	(function (p) {
		var o = !1;
		p.css('background-color', '#c00');
	})($('p'));
	*/

});
