using BlueSkyProject2.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace BlueSkyProject2.StepDefinitions
{
    [Binding]       
    public class DataDrivenWithTableSteps
    {
        DataTablePageObject dataTablePageObject;

        public DataDrivenWithTableSteps()
        {
            dataTablePageObject = new DataTablePageObject();
        }

        [When(@"I enter my email and password")]
        public void WhenIEnterMyEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Details>();
            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;
            dataTablePageObject.EnterEmailAndPassword(email, password);
        }
    }
}
