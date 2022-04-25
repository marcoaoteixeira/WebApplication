(function ($) {
    $(document).ready(function () {

        // Disable using keyboard arrows for input number.
        $("input[type=number].disable-step").on("focus", function () {
            $(this).on("keydown", function (event) {
                if (event.keyCode === 38 || event.keyCode === 40) {
                    event.preventDefault();
                }
            });
        });

    });
})(jQuery);