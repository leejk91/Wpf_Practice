using Season3_Day2_2.UI.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Season3_Day2_2.UI.Units
{
    public class StudyListBox : ListBox
    {
        static StudyListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StudyListBox), new FrameworkPropertyMetadata(typeof(StudyListBox)));
        }

        public StudyListBox()
        {
            ItemsSource = GetSamples();
        }

        private IEnumerable GetSamples()
        {
            List<User> users = new();
            users.Add(new User().GenData("Lee", "Seoul"));
            users.Add(new User().GenData("Lee2", "Busan"));
            users.Add(new User().GenData("Lee3", "Paris"));
            users.Add(new User().GenData("Lee4", "Home"));

            return users;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            // 기본값이 아래와 같이 되어있기 때문에 GetContainerForItemOverride를 통해
            // 내가 사용할 StudyListBoxItem로 대처한다.
            // return new ListBoxItem();
            return new StudyListBoxItem();
        }
    }
}
