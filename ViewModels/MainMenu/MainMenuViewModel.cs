using System.Diagnostics;
using SaviorIA.ViewModels.Base;
using SaviorIA.Views.Menu;

namespace SaviorIA.ViewModels.MainMenu;

public class MainMenuViewModel : ViewModelBase
{
	#region Comandos
	Command _goToRegister;
	public Command GoToRegisterCommand
	{
		get { return _goToRegister ??= new Command(() => GoToPageRegister(), () => !IsBusy); }
	}

	Command _goToDiagnostic;
	public Command GoToDiagnosticCommand
	{
		get { return _goToDiagnostic ??= new Command(() => GoToPageDiagnostic(), () => !IsBusy); }
	}

	Command _goToTests;
	public Command GoToTestsCommand
	{
		get { return _goToTests ??= new Command(() => GoToPageTests(), () => !IsBusy); }
	}


	#endregion





	private void GoToPageRegister()
	{
		Debug.WriteLine("Hola");
		Shell.Current.GoToAsync(nameof(Register));
	}

		private void GoToPageDiagnostic()
	{
		Shell.Current.GoToAsync(nameof(Diagnostic));
	}


	private void GoToPageTests()
	{
		Shell.Current.GoToAsync(nameof(Test));
	}

}