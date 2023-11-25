document.addEventListener('DOMContentLoaded', function () {
    const form_login = {
        email: document.getElementById("login_email"),
        password: document.getElementById("login_password"),
        button: document.querySelector(".login-button"),
        inputs: document.querySelectorAll(".wrapper-login input"),
    };

    const form_register = {
        login: document.getElementById("register_login"),
        email: document.getElementById("register_email"),
        password: document.getElementById("register_password"),
        confirm_password: document.getElementById("register_confirm_password"),
        button: document.querySelector(".register-button"),
        inputs: document.querySelectorAll(".wrapper-register input"),
    };

    function toggleDisplay(element) {
        if (element.style.display === "none") {
            element.style.display = "flex";
        } else {
            element.style.display = "none";
        }
    }

    function checkForm(form, button) {
        const values = Array.from(form.inputs).map(input => input.value);
        if (values.every(value => value.trim() !== "")) {
            button.classList.remove("disable");
        } else {
            button.classList.add("disable");
        }
    }

    function handleInput(event, form, button) {
        checkForm(form, button);
    }

    form_login.inputs.forEach(input => input.addEventListener("input", (e) => handleInput(e, form_login, form_login.button)));
    form_register.inputs.forEach(input => input.addEventListener("input", (e) => handleInput(e, form_register, form_register.button)));

    document.getElementById("click-to-login").addEventListener("click", () => toggleDisplay(document.querySelector(".wrapper-login")));
    document.querySelector(".overlay-login").addEventListener("click", () => toggleDisplay(document.querySelector(".wrapper-login")));

    document.getElementById("click-to-register").addEventListener("click", () => toggleDisplay(document.querySelector(".wrapper-register")));
    document.querySelector(".overlay-register").addEventListener("click", () => toggleDisplay(document.querySelector(".wrapper-register")));
});