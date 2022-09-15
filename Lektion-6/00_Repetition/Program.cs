
using _00_Repetition.Services;



ICustomerService customerService = new CustomerService();

customerService.Create();
customerService.Read();
customerService.Update();
customerService.Delete();

//customerService.SignIn("", "");
//customerService.SignUp();
//customerService.SignOut();



