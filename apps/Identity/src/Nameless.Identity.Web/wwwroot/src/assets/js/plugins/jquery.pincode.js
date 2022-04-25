(function ($) {
    $.fn.pincode = function (opts) {

        // check if is a form element
        if (this.length < 1 || this[0].nodeName !== "FORM") { return; }

        // merge options
        const settings = $.extend({
            pattern: /\d/,
            numeric: true,
            uppercase: false,
            size: 6,
            secure: true,
            containerSelector: ".pincode-group",
            previewDuration: 250,
            onInput: null,
            debug: false
        }, opts);

        const data = {
            $inputs: null
        };

        const __init__ = function () {
            definePins();
            initPins();
        };

        const definePins = function () {
            // create pincode container
            const $container = $(settings.containerSelector);

            // define inputs
            for (let idx = 0; idx < settings.size; idx++) {
                const $input = $(`<input type="text" name="pincode-${idx}" maxlength="1" tabindex="${idx + 1}" placeholder="·" autocomplete="off" />`).appendTo($container);

                if (settings.numeric) { $input.attr("inputmode", "numeric"); }
                if (settings.uppercase) { $input.css("text-transform", "uppercase") }
            }

            data.$inputs = $container.find("input[name^=pincode-]");

            // define width
            var percentage = Math.floor(92 / settings.size);
            data.$inputs.css("width", `${percentage}%`);

            !settings.debug || console.log("[definePins]", data.$inputs);
        };

        const initPins = function () {
            data.$inputs.each((index, elem) => {

                elem.addEventListener("input", function (event) {
                    onInputChange(index, event.currentTarget.value);
                });

                elem.addEventListener("keydown", function (event) {
                    onInputKeyDown(index, event);
                    if (event.key !== 'ArrowLeft' && event.key !== 'ArrowRight' && event.key !== 'ArrowUp' &&
                        event.key !== 'ArrowDown' && event.key !== 'Backspace' && event.key !== 'Delete') {
                        this.setAttribute("type", "text");
                    }
                });
            });

            !settings.debug || console.log("[initPins]");
        }

        const onInputChange = function (index, value) {
            const input = data.$inputs[index];

            if (validateInputValue(value)) {
                if (settings.secure && settings.previewDuration) {
                    setTimeout(() => {
                        input.setAttribute("type", "password");
                    }, settings.previewDuration);
                }
                focusNext(index);
            } else { input.value = ""; }

            collect();

            !settings.debug || console.log("[onInputChange]", `Index: ${index}`, `Value: ${value}`);
        };

        const onInputKeyDown = function (index, event) {
            switch (event.key) {
                case "ArrowLeft":
                    focusPrevious(index);
                    break;
                case "ArrowRight":
                    focusNext(index);
                    break;
                case "Backspace":
                    onInputErase(index, event);
                    break;
            }

            !settings.debug || console.log("[onInputKeyDown]", `Index: ${index}`, `Event: ${event}`);
        };

        const focusPrevious = function (index) {
            if ((index - 1) >= 0) {
                data.$inputs[index - 1].focus();
                data.$inputs[index - 1].select();
                return true;
            }
            return false;
        }

        const focusNext = function (index) {
            if ((index + 1) < settings.size) {
                data.$inputs[index + 1].focus();
                data.$inputs[index + 1].select();
                return true;
            }
            return false;
        }

        const onInputErase = function (index, event) {
            if (!data.$inputs[index].value.length) {
                focusPrevious(index);
                event.preventDefault();
            }

            !settings.debug || console.log("[onInputErase]", `Index: ${index}`, `Event: ${event}`);
        }

        const validateInputValue = function (value) {
            var result = settings.numeric ? !!value.match(settings.pattern) : value.length <= 1;

            !settings.debug || console.log("[validateInputValue]", `Value: ${value}`, `Result: ${result}`);

            return result;
        };

        const collect = function () {
            let value = "";
            data.$inputs.each((idx, elem) => {
                value += settings.uppercase ? elem.value.toUpperCase() : elem.value;
            });
            if (settings.onInput) {
                settings.onInput(value);
            }

            !settings.debug || console.log("[collect]", `Value: ${value}`);
        };

        __init__();
    }

})(jQuery);