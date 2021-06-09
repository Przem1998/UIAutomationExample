using NUnit.Framework;
using System.Diagnostics;

namespace UIAutomationTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        public void Test1()
        {
            Assert.Pass();
        }

        //private void GetBackgroundColorAttribute()
        //{
        //    // Start application.
        //    Process p = Process.Start(@"\bin\Debug\Calculator.exe", "text.txt");

        //    // target --> The root AutomationElement.
        //    AutomationElement target = AutomationElement.FromHandle(p.MainWindowHandle);

        //    // Specify the control type we're looking for, in this case 'Document'
        //    PropertyCondition cond = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Document);

        //    AutomationElement textProvider = target.FindFirst(TreeScope.Descendants, cond);

        //    TextPattern textpatternPattern = textProvider.GetCurrentPattern(TextPattern.Pattern) as TextPattern;

        //    if (textpatternPattern == null)
        //    {
        //        Console.WriteLine("Root element does not contain a descendant that supports TextPattern.");
        //        return;
        //    }

        //    Object oAttribute = textpatternPattern.DocumentRange.GetAttributeValue(TextPattern.BackgroundColorAttribute);
        //    if (oAttribute == TextPattern.MixedAttributeValue)
        //    {
        //        Console.WriteLine("Mixed background colors.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(oAttribute.ToString());
        //    }
        //}
    }
}