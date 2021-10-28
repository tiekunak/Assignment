
// This function clear all the values
function clearScreen() {
    document.getElementById("result").value = "0";
   }

   var screen = document.getElementById("result");
   // This function display values
   function display(value) {
        if (screen.value == "0") {
            screen.value = value;
        }else {
            screen.value += value;
        }
            
         
   }


   // This function evaluates the expression and return result
   function calculate() {
    var p = document.getElementById("result").value;
    var q = eval(p);
    document.getElementById("result").value = q;
   }
