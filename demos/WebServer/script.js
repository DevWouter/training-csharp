document.getElementById("input").addEventListener("keyup", function(event) {
    const output = document.getElementById("output");
    output.innerText = "Hello " + event.target.value;
});