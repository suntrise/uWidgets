using System.Reflection;
using Calendar.Locales;
using Calendar.Models;
using Calendar.Views;
using Calendar.Views.Settings;
using uWidgets.Core.Models.Attributes;

[assembly: AssemblyCompany("creewick")]
[assembly: AssemblyVersion("1.0.5")]

[assembly: WidgetInfo(typeof(Date), null, null, "Calendar_Date_Title", "Calendar_Date_Subtitle")]
[assembly: WidgetInfo(typeof(Month), typeof(MonthCalendarModel), typeof(MonthCalendarSettings), "Calendar_Month_Title", "Calendar_Month_Subtitle")]
[assembly: Locale(typeof(Locale), "Calendar", "M21.75,3 C23.5449254,3 25,4.45507456 25,6.25 L25,21.75 C25,23.5449254 23.5449254,25 21.75,25 L6.25,25 C4.45507456,25 3,23.5449254 3,21.75 L3,6.25 C3,4.45507456 4.45507456,3 6.25,3 L21.75,3 Z M23.5,9.503 L4.5,9.503 L4.5,21.75 C4.5,22.7164983 5.28350169,23.5 6.25,23.5 L21.75,23.5 C22.7164983,23.5 23.5,22.7164983 23.5,21.75 L23.5,9.503 Z M8.74877715,17.5014095 C9.43913308,17.5014095 9.99877715,18.0610536 9.99877715,18.7514095 C9.99877715,19.4417655 9.43913308,20.0014095 8.74877715,20.0014095 C8.05842121,20.0014095 7.49877715,19.4417655 7.49877715,18.7514095 C7.49877715,18.0610536 8.05842121,17.5014095 8.74877715,17.5014095 Z M14.0032585,17.5014095 C14.6936145,17.5014095 15.2532585,18.0610536 15.2532585,18.7514095 C15.2532585,19.4417655 14.6936145,20.0014095 14.0032585,20.0014095 C13.3129026,20.0014095 12.7532585,19.4417655 12.7532585,18.7514095 C12.7532585,18.0610536 13.3129026,17.5014095 14.0032585,17.5014095 Z M8.74877715,12.5014095 C9.43913308,12.5014095 9.99877715,13.0610536 9.99877715,13.7514095 C9.99877715,14.4417655 9.43913308,15.0014095 8.74877715,15.0014095 C8.05842121,15.0014095 7.49877715,14.4417655 7.49877715,13.7514095 C7.49877715,13.0610536 8.05842121,12.5014095 8.74877715,12.5014095 Z M14.0032585,12.5014095 C14.6936145,12.5014095 15.2532585,13.0610536 15.2532585,13.7514095 C15.2532585,14.4417655 14.6936145,15.0014095 14.0032585,15.0014095 C13.3129026,15.0014095 12.7532585,14.4417655 12.7532585,13.7514095 C12.7532585,13.0610536 13.3129026,12.5014095 14.0032585,12.5014095 Z M19.2577399,12.5014095 C19.9480958,12.5014095 20.5077399,13.0610536 20.5077399,13.7514095 C20.5077399,14.4417655 19.9480958,15.0014095 19.2577399,15.0014095 C18.567384,15.0014095 18.0077399,14.4417655 18.0077399,13.7514095 C18.0077399,13.0610536 18.567384,12.5014095 19.2577399,12.5014095 Z M21.75,4.5 L6.25,4.5 C5.28350169,4.5 4.5,5.28350169 4.5,6.25 L4.5,8.003 L23.5,8.003 L23.5,6.25 C23.5,5.28350169 22.7164983,4.5 21.75,4.5 Z")]