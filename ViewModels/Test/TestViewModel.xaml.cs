using System.Diagnostics;
using SaviorIA.ViewModels.Base;
using SaviorIA.Views.Menu.Tests;

namespace SaviorIA.ViewModels.MainMenu;
public partial class TestViewModel : ViewModelBase
{
	#region Comandos
	Command _goToBeck;
	public Command GoToBeckCommand
	{
		get { return _goToBeck ??= new Command(() => GoToBeck(), () => !IsBusy); }
	}

	Command _goToSadPerson;
	public Command GoToSadPersonCommand
	{
		get { return _goToSadPerson ??= new Command(() => GoToSadPerson(), () => !IsBusy); }
	}
	#endregion 


	private void GoToBeck()
	{
		Debug.WriteLine("here");
		Shell.Current.GoToAsync(nameof(Beck));
	}
	private void GoToSadPerson()
	{
		Debug.WriteLine("here");
		Shell.Current.GoToAsync(nameof(SadPerson));
	}
}