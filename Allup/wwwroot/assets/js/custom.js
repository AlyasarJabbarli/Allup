$(document).ready(function (){
    $('.modaldetail').click(function (e){
        e.preventDefault();
        
        let url = $(this).attr('href');
        console.log(url);

        fetch(url).then(response =>
        {
            return response.text();
        }).then(data => {
            $('.modal-content').html(data);

            $('.quick-view-image').slick({
                slidesToShow: 1,
                slidesToScroll: 1,
                arrows: false,
                dots: false,
                fade: true,
                asNavFor: '.quick-view-thumb',
                speed: 400,
            });

            $('.quick-view-thumb').slick({
                slidesToShow: 4,
                slidesToScroll: 1,
                asNavFor: '.quick-view-image',
                dots: false,
                arrows: false,
                focusOnSelect: true,
                speed: 400,
            });
        })
    })
    $('.searchinput').keyup(function () {
        let inputvalue = $(this).val();
        console.log(inputvalue);

        let url = $(this).data(`url`)
        console.log(url);

        url = url + "?search=" + inputvalue;
        console.log(url);
        if (inputvalue) {
            fetch(url)
                .then(res => res.text())
                .then(data => {
                    $('.search-body .list-group').html(data);
                })
        }
        else {
            $('.search-body .list-group').html('');
        }
        
    })
    $('.addbasket').click(function (e) {
        e.preventDefault();

        let url = $(this).attr('href');

        fetch(url)
            .then(res => res.text())
            .then(data => {
                $('.mini-cart').html(data);
        })
    })
    $('.product-close').click(function (e) {
        e.preventDefault();

        let url = $(this).attr('href');

        fetch(url).then(res => res.text()).then(data => {
            $('.mini-cart').html(data);
        })
    })
})
