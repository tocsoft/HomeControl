using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeControl.Controls
{
    public class Rotational : ContentView
    {
        public View Landscape { get; set; }
        public View Portrait { get; set; }
        private bool isPortrait;

        protected override void OnParentSet()
        {
            base.OnParentSet();
            VisualElement view = ParentView;
            while (!(view is Page))
            {
                view = view.ParentView;
            }
            Page page = (Page)view;
            page.Disappearing += page_Disappearing;
            page.Appearing += page_Appearing;
        }

        void page_Appearing(object sender, EventArgs e)
        {
            Orientation.RotationChanged += CurrentOrientation_Changed;
            Update();
        }

        private void CurrentOrientation_Changed(object sender, EventArgs e)
        {
            Update();
        }

        void page_Disappearing(object sender, EventArgs e)
        {
            Orientation.RotationChanged -= CurrentOrientation_Changed;
        }

        private void Update()
        {
            if (Content == null || Orientation.IsLandscape && isPortrait ||
                !Orientation.IsLandscape && !isPortrait)
            {
                if (Orientation.IsLandscape)
                {
                    isPortrait = false;
                    Content = Landscape;
                }
                else
                {
                    isPortrait = true;
                    Content = Portrait;
                }
            }
        }
    }
}
