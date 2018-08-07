// string.match(regexp)
let mail = $("exampleInputEmail1").val();
let pattern = /^\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b$/i

if(!pattern.test(mail))
{
    alert('not a valid e-mail address');
}​

let pass = $("exampleInputPassword1").val();
if (pass.length < 6 ){
    alert('password should be more than 6 characters');
}