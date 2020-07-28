
var buttonOk = document.createElement("button");
    buttonOk.innerHTML = "Ok";

var buttonAnuluj = document.createElement("button");
    buttonAnuluj.innerHTML = "Anuluj";

var body = document.getElementsByTagName("body")[0];
body.appendChild(buttonOk);

var body = document.getElementsByTagName("body")[0];
body.appendChild(buttonAnuluj);

var Okclicked = false
var Anulujclicked = false

buttonOk.addEventListener ("click", function() {
  Okclicked = true;
alert(optionalPow(2,3));
});

buttonAnuluj.addEventListener ("click", function () {
  Anulujclicked = true;
alert(optionalPow(2,3));
});

function optionalPow(a,b) {
if(Okclicked)
{
var score = Math.pow(a,b);
Okclicked = false;
}
if(Anulujclicked)
{
var score = Math.pow(b,a);
Anulujclicked = false;
}

return score;
}
