using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageApp
{
    public class MainViewModel : ObservableObject
    {
        public List<LanguageModel> Languages { get; set; }

        private LanguageModel _languageModel;
        public LanguageModel LanguageModel
        {
            get => _languageModel;
            set => SetProperty2(ref _languageModel, value, LanguageModelChanged);
        }

        private void SetProperty2<T>(ref T value1, T value2, Action<T> changed)
        {
            value1 = value2;

        }

        private void LanguageModelChanged(LanguageModel obj)
        {
            throw new NotImplementedException();
        }

        public MainViewModel()
        {
            Languages = GetLanguage();
        }

        private List<LanguageModel> GetLanguage()
        {
            List<LanguageModel> source = new();
            return source;
        }
    }
}
