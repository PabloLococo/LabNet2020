
function myFunction() {
  var myWindow = window.open("ggg", "myWindow", "width=200,height=100");
  myWindow.document.write("<p>This is 'myWindow'</p>");
  myWindow.opener.document.write("<p>This is the source window!</p>");
}
