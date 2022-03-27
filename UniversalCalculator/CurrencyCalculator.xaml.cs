using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyCalculator : Page
	{
		const double US_EURO = 0.85189982;
		const double US_BRITISH = 0.72872436;
		const double US_INDIAN = 74.257327;
		const double EURO_US = 1.1739732;
		const double EURO_BRITISH = 0.8556672;
		const double EURO_INDIAN = 87.00755;
		const double BRITISH_US = 1.371907;
		const double BRITISH_EURO = 1.1686692;
		const double BRITISH_INDIAN = 101.68635;
		const double INDIAN_US = 0.011492628;
		const double INDIAN_EURO = 0.013492774;
		const double INDIAN_BRITISH = 0.0098339397;

		public CurrencyCalculator()
		{
			this.InitializeComponent();
		}

		private void currencyConverterButton_Click(object sender, RoutedEventArgs e)
		{
			double amount;
			double result;
			double conversionRate;

			amount = double.Parse(amountTextBox.Text);

			if (fromCurrency.SelectedValue.ToString() == "USD - US Dollar")
			{

				convertTextBlock.Text = amount + " USD = ";

				if (toCurrency.SelectedValue.ToString() == "EUR - Euro")
				{
					conversionRate = US_EURO;
					fromCountryTextBlock.Text = "1USD = " + US_EURO + " EUR";
					toCountryTextBlock.Text = "1EUR = " + EURO_US + " USD";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " European Euro";
				}
				if (toCurrency.SelectedValue.ToString() == "GBP - British")
				{
					conversionRate = US_BRITISH;
					fromCountryTextBlock.Text = "1USD = " + US_BRITISH + " GBP";
					toCountryTextBlock.Text = "1GBP = " + BRITISH_US + " USD";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " British Pounds";
				}
				if (toCurrency.SelectedValue.ToString() == "INR- Indian Rupee")
				{
					conversionRate = US_INDIAN;
					fromCountryTextBlock.Text = "1USD = " + US_INDIAN + " INR";
					toCountryTextBlock.Text = "1INR = " + INDIAN_US + " USD";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " Indian Rupee";
				}

			}
			else if (fromCurrency.SelectedValue.ToString() == "EUR - Euro")
			{
				convertTextBlock.Text = amount + " EUR = ";

				if (toCurrency.SelectedValue.ToString() == "USD - US Dollar")
				{
					conversionRate = EURO_US;
					fromCountryTextBlock.Text = "1EUR = " + EURO_US + " USD";
					toCountryTextBlock.Text = "1USD = " + US_EURO + " EUR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " US Dollars";
				}
				if (toCurrency.SelectedValue.ToString() == "GBP - British")
				{
					conversionRate = EURO_BRITISH;
					fromCountryTextBlock.Text = "1EUR = " + EURO_BRITISH + " GBP";
					toCountryTextBlock.Text = "1GBP = " + BRITISH_EURO + " EUR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " British Pounds";
				}
				if (toCurrency.SelectedValue.ToString() == "INR- Indian Rupee")
				{
					conversionRate = EURO_INDIAN;
					fromCountryTextBlock.Text = "1EUR = " + EURO_INDIAN + " INR";
					toCountryTextBlock.Text = "1INR = " + INDIAN_EURO + " EUR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " Indian Rupee";
				}

			}
			else if (fromCurrency.SelectedValue.ToString() == "GBP - British")
			{
				convertTextBlock.Text = amount + " GBP = ";

				if (toCurrency.SelectedValue.ToString() == "USD - US Dollar")
				{
					conversionRate = BRITISH_US;
					fromCountryTextBlock.Text = "1GBP = " + BRITISH_US + " USD";
					toCountryTextBlock.Text = "1USD = " + US_BRITISH + " GBP";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " US Dollars";
				}
				if (toCurrency.SelectedValue.ToString() == "EUR - Euro")
				{
					conversionRate = BRITISH_EURO;
					fromCountryTextBlock.Text = "1GBP = " + BRITISH_EURO + " EUR";
					toCountryTextBlock.Text = "1EUR = " + EURO_BRITISH + " GBP";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " European Euro";
				}
				if (toCurrency.SelectedValue.ToString() == "INR- Indian Rupee")
				{
					conversionRate = BRITISH_US;
					fromCountryTextBlock.Text = "1GBP = " + BRITISH_INDIAN + " INR";
					toCountryTextBlock.Text = "1INR = " + INDIAN_BRITISH + " GBP";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " Indian Rupee";
				}

			}
			else if (fromCurrency.SelectedValue.ToString() == "INR- Indian Rupee")
			{
				convertTextBlock.Text = amount + " INR = ";

				if (toCurrency.SelectedValue.ToString() == "USD - US Dollar")
				{
					conversionRate = INDIAN_US;
					fromCountryTextBlock.Text = "1INR = " + INDIAN_US + " USD";
					toCountryTextBlock.Text = "1USD = " + US_INDIAN + " INR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " US Dollars";
				}
				if (toCurrency.SelectedValue.ToString() == "EUR - Euro")
				{
					conversionRate = INDIAN_EURO;
					fromCountryTextBlock.Text = "1INR = " + INDIAN_EURO + " EUR";
					toCountryTextBlock.Text = "1EUR = " + EURO_INDIAN + " INR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " European Euro";
				}
				if (toCurrency.SelectedValue.ToString() == "GBP - British")
				{
					conversionRate = INDIAN_BRITISH;
					fromCountryTextBlock.Text = "1INR = " + INDIAN_BRITISH + " GBP";
					toCountryTextBlock.Text = "1GBP = " + BRITISH_INDIAN + " INR";
					result = amount * conversionRate;
					resultTextBlock.Text = result.ToString() + " British Pounds";
				}

			}

			////conversion calculation
			//result = amount * conversionRate;
			//resultTextBlock.Text = result.ToString("C");
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
