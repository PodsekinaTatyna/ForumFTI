// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const form = {
  email: document.getElementById("email"),
  password: document.getElementById("password"),
  button: document.querySelector(".login-button"),
  inputs: document.querySelectorAll("input"),
};

document
  .getElementById("click-to-hide")
  .addEventListener("click", hiddenOpen_Closeclick);
document
  .querySelector(".overlay")
  .addEventListener("click", hiddenOpen_Closeclick);

function handleInput(e, name) {
  const { value } = e.target;
  if (value) {
    form[name].classList.add("filed");
  } else {
    form[name].classList.remove("filed");
  }
}

function checkForm() {
  const email = form.email.getElementsByTagName("input")[0].value;
  const password = form.password.getElementsByTagName("input")[0].value;

  if (email && password) {
    form.button.classList.remove("disable");
  } else {
    form.button.classList.add("disable");
  }
}

function hiddenOpen_Closeclick() {
  let x = document.querySelector(".wrapper");
  if (x.style.display == "none") {
    x.style.display = "grid";
  } else {
    x.style.display = "none";
  }
}

form.email.oninput = (e) => handleInput(e, "email");
form.password.oninput = (e) => handleInput(e, "password");
form.inputs.forEach((e) => e.addEventListener("input", checkForm));