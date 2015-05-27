using SmartNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScrumCards_Static.ViewModel
{
    class DisplayViewModel : ViewModelBase
    {

        #region Fields

        private ICommand _displayZeroCommand;
        private ICommand _displayHalfCommand;
        private ICommand _displayOneCommand;
        private ICommand _displayTwoCommand;
        private ICommand _displayThreeCommand;
        private ICommand _displayFiveCommand;
        private ICommand _displayEightCommand;
        private ICommand _displayThirteenCommand;
        private ICommand _displayTwentyCommand;
        private ICommand _displayFourtyCommand;
        private ICommand _displayHundredCommand;
        private ICommand _displayQuestionCommand;
        private ICommand _displayInfinityCommand;
        private ICommand _surpriseCommand;
        private ICommand _goBackCommand;
        private ICommand _mainPageCommand;

        private string _displayText = "Default Text";

        #endregion

        #region Constructor

        public DisplayViewModel()
        {
            _displayZeroCommand = new DelegateCommand(ExecuteDisplayZeroCommand, CanExecuteDisplayCommand);
            _displayHalfCommand = new DelegateCommand(ExecuteDisplayHalfCommand, CanExecuteDisplayCommand);
            _displayOneCommand = new DelegateCommand(ExecuteDisplayOneCommand, CanExecuteDisplayCommand);
            _displayTwoCommand = new DelegateCommand(ExecuteDisplayTwoCommand, CanExecuteDisplayCommand);
            _displayThreeCommand = new DelegateCommand(ExecuteDisplayThreeCommand, CanExecuteDisplayCommand);
            _displayFiveCommand = new DelegateCommand(ExecuteDisplayFiveCommand, CanExecuteDisplayCommand);
            _displayEightCommand = new DelegateCommand(ExecuteDisplayEightCommand, CanExecuteDisplayCommand);
            _displayThirteenCommand = new DelegateCommand(ExecuteDisplayThirteenCommand, CanExecuteDisplayCommand);
            _displayTwentyCommand = new DelegateCommand(ExecuteDisplayTwentyCommand, CanExecuteDisplayCommand);
            _displayFourtyCommand = new DelegateCommand(ExecuteDisplayFourtyCommand, CanExecuteDisplayCommand);
            _displayHundredCommand = new DelegateCommand(ExecuteDisplayHundredCommand, CanExecuteDisplayCommand);
            _displayQuestionCommand = new DelegateCommand(ExecuteDisplayQuestionCommand, CanExecuteDisplayCommand);
            _displayInfinityCommand = new DelegateCommand(ExecuteDisplayInfinityCommand, CanExecuteDisplayCommand);
            _surpriseCommand = new DelegateCommand(ExecuteSurpriseCommand, CanExecuteDisplayCommand);
            _goBackCommand = new DelegateCommand(ExecuteGoBackCommand, CanExecuteDisplayCommand);
            _mainPageCommand = new DelegateCommand(ExecuteMainPageCommand, CanExecuteDisplayCommand);
        }

        #endregion

        #region Properties

        public string DisplayText
        {
            get
            {
                return _displayText;
            }
            set
            {
                _displayText = value;
                OnPropertyChanged("DisplayText");
            }
        }

        #endregion

        #region Commands

        public ICommand DisplayZeroCommand
        {
            get
            {
                return _displayZeroCommand;
            }
        }

        public ICommand DisplayHalfCommand
        {
            get
            {
                return _displayHalfCommand;
            }
        }

        public ICommand DisplayOneCommand
        {
            get
            {
                return _displayOneCommand;
            }
        }

        public ICommand DisplayTwoCommand
        {
            get
            {
                return _displayTwoCommand;
            }
        }

        public ICommand DisplayThreeCommand
        {
            get
            {
                return _displayThreeCommand;
            }
        }

        public ICommand DisplayFiveCommand
        {
            get
            {
                return _displayFiveCommand;
            }
        }

        public ICommand DisplayEightCommand
        {
            get
            {
                return _displayEightCommand;
            }
        }

        public ICommand DisplayThirteenCommand
        {
            get
            {
                return _displayThirteenCommand;
            }
        }

        public ICommand DisplayTwentyCommand
        {
            get
            {
                return _displayTwentyCommand;
            }
        }

        public ICommand DisplayFourtyCommand
        {
            get
            {
                return _displayFourtyCommand;
            }
        }

        public ICommand DisplayHundredCommand
        {
            get
            {
                return _displayHundredCommand;
            }
        }

        public ICommand DisplayQuestionCommand
        {
            get
            {
                return _displayQuestionCommand;
            }
        }

        public ICommand DisplayInfinityCommand
        {
            get
            {
                return _displayInfinityCommand;
            }
        }

        public ICommand SurpriseCommand
        {
            get
            {
                return _surpriseCommand;
            }
        }

        public ICommand GoBackCommand
        {
            get
            {
                return _goBackCommand;
            }
        }

        public ICommand MainPageCommand
        {
            get
            {
                return _mainPageCommand;
            }
        }

        #endregion

        #region Public Methods

        public void EntryPoint(string text)
        {
            DisplayText = text;
        }

        #endregion

        #region Private Methods

        private bool CanExecuteDisplayCommand(object obj)
        {
            return true;
        }

        private void ExecuteDisplayZeroCommand(object obj)
        {
            UpdateContent("0");
        }

        private void ExecuteDisplayHalfCommand(object obj)
        {
            UpdateContent("1/2");
        }

        private void ExecuteDisplayOneCommand(object obj)
        {
            UpdateContent("1");
        }

        private void ExecuteDisplayTwoCommand(object obj)
        {
            UpdateContent("2");
        }

        private void ExecuteDisplayThreeCommand(object obj)
        {
            UpdateContent("3");
        }

        private void ExecuteDisplayFiveCommand(object obj)
        {
            UpdateContent("5");
        }

        private void ExecuteDisplayEightCommand(object obj)
        {
            UpdateContent("8");
        }

        private void ExecuteDisplayThirteenCommand(object obj)
        {
            UpdateContent("13");
        }

        private void ExecuteDisplayTwentyCommand(object obj)
        {
            UpdateContent("20");
        }

        private void ExecuteDisplayFourtyCommand(object obj)
        {
            UpdateContent("40");
        }

        private void ExecuteDisplayHundredCommand(object obj)
        {
            UpdateContent("100");
        }

        private void ExecuteDisplayQuestionCommand(object obj)
        {
            UpdateContent("?");
        }

        private void ExecuteDisplayInfinityCommand(object obj)
        {
            UpdateContent("∞");
        }

        private void ExecuteSurpriseCommand(object obj)
        {
            SmartNavigationService.Current.Navigate<DisplayViewModel>("/Page/SurprisePage.xaml",
                context => context.EntryPoint(DisplayText));
        }

        private void ExecuteGoBackCommand(object obj)
        {
            UpdateContent(DisplayText);
        }

        private void ExecuteMainPageCommand(object obj)
        {
            SmartNavigationService.Current.Navigate<DisplayViewModel>("/MainPage.xaml",
                context => context.EntryPoint(DisplayText));
        }

        private void UpdateContent(string content)
        {

            SmartNavigationService.Current.Navigate<DisplayViewModel>("/Page/DisplayPage.xaml",
                context => context.EntryPoint(content));
        }

        #endregion

    }
}
