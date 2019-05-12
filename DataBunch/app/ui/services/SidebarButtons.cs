using System;
using System.Collections.Generic;
using Bunifu.Framework.UI;

namespace DataBunch.app.ui.services
{
    public class SidebarButtons
    {
        private List<BunifuFlatButton> buttons;
        private FormWithSidebar formWithSidebar;

        public SidebarButtons(List<BunifuFlatButton> availableButtons, FormWithSidebar formWithSidebar = null)
        {
            this.buttons = availableButtons;
            this.formWithSidebar = formWithSidebar;

            init();
        }

        private void init()
        {
            buttons.ForEach(button => {
                button.Click += onButtonClick;
                turnOff(button);
            });
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            buttons.ForEach(turnOff);

            turnOn((BunifuFlatButton) sender);

            formWithSidebar?.onSidebarButtonClick(((BunifuFlatButton) sender).Tag.ToString());
        }

        public void toggle(string buttonTag)
        {
            var button = buttons.Find(btn => btn.Tag.ToString() == buttonTag);

            toggle(button);
        }

        public void turnOn(string buttonTag)
        {
            buttons.ForEach(turnOff);
            var button = buttons.Find(btn => btn.Tag.ToString() == buttonTag);

            turnOn(button);
        }

        public void turnOff(string buttonTag)
        {
            buttons.ForEach(turnOff);
            var button = buttons.Find(btn => btn.Tag.ToString() == buttonTag);

            turnOff(button);
        }

        public void toggle(BunifuFlatButton button)
        {
            if (button != null && button.selected) {
                turnOff(button);
            } else {
              turnOn(button);
            }
        }

        public void turnOff(BunifuFlatButton button)
        {
            if (button == null) {
                return;
            }

            button.selected = false;
        }

        public void turnOn(BunifuFlatButton button)
        {
            if (button == null) {
                return;
            }

            button.selected = true;
        }

        public void hideAll()
        {
            buttons.ForEach(btn => btn.Visible = false);
        }

        public void showAll()
        {
            buttons.ForEach(btn => btn.Visible = true);
        }

        public void hide(string tag)
        {
            var button = buttons.Find(btn => btn.Tag.ToString() == tag);

            if (button != null) {
                button.Visible = false;
            }
        }

        public void show(string tag)
        {
            var button = buttons.Find(btn => btn.Tag.ToString() == tag);

            if (button != null) {
                button.Visible = true;
            }
        }

        public interface FormWithSidebar
        {
            void onSidebarButtonClick(string tag);
        }
    }
}
