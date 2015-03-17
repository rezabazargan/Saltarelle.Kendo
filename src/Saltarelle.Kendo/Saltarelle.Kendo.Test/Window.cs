using jQueryApi;
using Saltarelle.Kendo.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saltarelle.Kendo.Test
{
    public class Window
    {
        public static jQueryObject jQueryWindow
        {
            get
            {
                var obj = jQuery.Select("#Window");
                if (obj.Length == 0)
                    jQuery.Select("body").Append(jQuery.Select("<div>").Attribute("id", "Window"));
                return jQuery.Select("#Window");
            }
        }

        public static void Start()
        {
            jQuery.Select("#SimpleWindow").On("click", eve => {
                OpenSimpleWindow();
            });
            jQuery.Select("#AjaxWindow").On("click", eve =>
            {
                OpenAjaxWindow();
            });
            ApiHandler();

        }



        private static void OpenAjaxWindow()
        {
            var windowElement = jQueryWindow.KendoWindow(new Saltarelle.Kendo.Window.WindowOption()
            {
                Actions = new string[] { "refresh", "close" },
                Content = "/Window/AjaxContent/",
                Draggable = true,
                Height = "200px",
                Iframe = false,
                Modal = true,
                Title = "ajax Window",
                Width = "500px"
            });
            ((WindowObject)windowElement.GetDataValue("kendoWindow")).Center().Open();
        }

        private static void OpenSimpleWindow()
        {
            var windowElement = jQueryWindow.KendoWindow(new Saltarelle.Kendo.Window.WindowOption()
            {
                Actions = new string[] { "refresh", "close","restore" },
                Content = "Simple Window",
                Draggable = true,
                Height = "400px",
                Iframe = false,
                Modal = false,
                Title = "simple Window",
                Width = "600px"
            });
            ((WindowObject)windowElement.GetDataValue("kendoWindow")).Center().Open();
        }


        private static void ApiHandler()
        {
            jQuery.Select("#maximizeWindow").On("click", eve => { 
                DoAction(c=> c.Restore());
            });
            jQuery.Select("#minimizeWindow").On("click", eve =>
            {
                DoAction(c => c.Minimize());
            });
            jQuery.Select("#closeWindow").On("click", eve =>
            {
                DoAction(c => c.Close());
            });

            jQuery.Select("#centerWindow").On("click", eve =>
            {
                DoAction(c => c.Center());
            });

        }

        private static void DoAction(Action<WindowObject> act)
        {
            var window = ((WindowObject)jQueryWindow.GetDataValue("kendoWindow"));
            if(!Script.IsNullOrUndefined(window))
                act(window);

        }
    }
}
