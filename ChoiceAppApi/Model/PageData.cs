using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoiceAppApi.Model
{
    public class PageData
    {
        public int PageID { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public bool Ending { get; set; }
        public bool Result { get; set; }
        public bool Victory { get; set; }

        public ButtonData[] ButtonData { get; set; }

        public PageData(int id, string title, string description, bool ending, bool result, bool victory, ButtonData[] buttonText)
        {
            PageID = id;
            PageTitle = title;
            PageDescription = description;
            ButtonData = buttonText;
            Ending = ending;
            Result = result;
            Victory = victory;
        }

        public PageData()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(PageID)}: {PageID}, {nameof(PageTitle)}: {PageTitle}, {nameof(PageDescription)}: {PageDescription}, {nameof(Ending)}: {Ending}, {nameof(Result)}: {Result}, {nameof(Victory)}: {Victory}, {nameof(ButtonData)}: {ButtonData}";
        }
    }


    public class ButtonData
    {

        public int ButtonID { get; set; }
        public string ButtonDescription { get; set; }
        public int ButtonDestinationPage { get; set; }

        public ButtonData(int id, string description, int destinationPage)
        {
            ButtonID = id;
            ButtonDescription = description;
            ButtonDestinationPage = destinationPage;
        }

        public ButtonData()
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(ButtonID)}: {ButtonID}, {nameof(ButtonDescription)}: {ButtonDescription}, {nameof(ButtonDestinationPage)}: {ButtonDestinationPage}";
        }
    }
}
