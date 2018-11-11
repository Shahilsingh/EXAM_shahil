//Submit form with id function
function submit_option() {
	
	if(validation())// Calling validation function for all fields except name
	  { 
		var name = document.getElementById("name").value;
		var email = document.getElementById("email").value;
		var password = document.getElementById("password").value;
		var phone_number = document.getElementById("phone").value;
		var age = document.getElementById("age").value;

	    //document.getElementById("form_id").submit();//form submission
	    //alert(" Name : "+name+" \n Email : "+email+" \n Form Id : "+document.getElementById("form_id").getAttribute("id")+"\n\n Form Submitted Successfully......");
	//	alert(" Name : "+name+" \n Email : "+email+" \n password : "+password+" \n phone number : "+phone_number +" \n age : "+age+
	//	"\n\n Form Submitted Successfully......");
			document.writeln("Thank you! You have just entered the following:");
            document.writeln("<pre>");
            document.writeln(" Name    : " + name);
            document.writeln("Password     : " + password);
            document.writeln("Email Address : " + email);
            document.writeln("Phone Number     : " + phone_number);
            document.writeln("Age : " + age);
	  }	
}	

//var captcha;
 
function refresh_option() {
								var a = Math.ceil(Math.random() * 10) + '';
                                var b = Math.ceil(Math.random() * 10) + '';
                                var c = Math.ceil(Math.random() * 10) + '';
                                var d = Math.ceil(Math.random() * 10) + '';
                                var e = Math.ceil(Math.random() * 10) + '';
                                var f = Math.ceil(Math.random() * 10) + '';
                                var g = Math.ceil(Math.random() * 10) + '';
                                var code = a + ' ' + b + ' ' + ' ' + c + ' ' + d + ' ' + e + ' ' + f + ' ' + g; 
								document.getElementById("captcha").value = code
   // captcha=a.toString()+b.toString()+c.toString()+d.toString();
     
    //document.getElementById("captcha").value = captcha;
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	

//cancel function to reset all fields
function cancel_option(){
	  document.getElementById("form_id").reset(); 		
    }
	  // Remove the spaces from the entered and generated captcha code
         function removeSpaces(string) {
           return string.split(' ').join('');
        }
	 


//  Name and Email validation Function
function validation(){

	var randomCaptcha = removeSpaces(document.getElementById('captcha').value);
    var enterCaptcha = removeSpaces(document.getElementById('inputTextCaptcha').value);
	//var input_captcha=document.getElementById("inputTextCaptcha").value;

	var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
	var password = document.getElementById("password").value; 
	var phone_number = document.getElementById("phone").value;
	var age = document.getElementById("age").value;
	var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
//	var passwordReg = /^(?=.*\d)(?=.*[a-zA-Z])[a-zA-Z0-9]{7,}$/;  // 1 lower 1 upper 1 digit min char 8
	var passwordReg = /^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){2,})(?=(.*[\W]){1,})(?!.*\s).{8,}$/;// 1 lower 1 upper 2 digit & special character with min char 8

	if( name ==='' || email ==='' || password ==='' || phone_number =='' || age =='' || enterCaptcha =='' )
	   {
		alert("Please fill all fields...!!!!!!");
		return false;
	   }
	else if(age.length != 3){
		 alert("Invalid age min 3 charecters...!!!!!!");
		 return false;
	}	
	else if(!(email).match(emailReg))
	   {
		 alert("Invalid Email...!!!!!!");
		 return false;
	   }
	else if(!(password).match(passwordReg))
	   {
		 alert("Invalid Password...!!!!!!");
		 return false;
	   }
	else if(phone_number.length != 10)
		{
			alert("Invalid Phone Number...!!!!!!");
			return false;
		}
	else if( enterCaptcha != randomCaptcha)
		{
			alert("Entered captcha not match with random...!!!!!!");
			return false;
		}
	else
	   {
	     return true;
	   }   
}
