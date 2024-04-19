using CsvHelper.Configuration.Attributes;

namespace DataAccess;

public class Transaction
{
    [Name("Booking Date")]
    public DateTime BookingDate { get; set; }

    [Name("Amount")]
    public decimal Amount { get; set; } = 0;

    [Name("Credit Debit Indicator")]
    public string Indicator { get; set; } = string.Empty;

    [Name("type")]
    public string Type { get; set; } = string.Empty;

    [Name("Type Group")]
    public string TypeGroup { get; set; } = string.Empty;

    [Name("Reference")]
    public string Reference { get; set; } = string.Empty;

    [Name("Instructed Currency")]
    public string InstructedCurrency { get; set; } = string.Empty;

    [Name("Currency Exchange Rate")]
    public string CurrencyExchangeRate { get; set; } = string.Empty;

    [Name("Instructed Amount")]
    public string InstructedAmount { get; set; } = string.Empty;

    [Name("Description")]
    public string Description { get; set; } = string.Empty;

    [Name("Category")]
    public string Category { get; set; } = string.Empty;

    [Name("Check Serial Number")]
    public string CheckSerialNumber { get; set; } = string.Empty;

    [Name("Card Ending")]
    public string CardEnding { get; set; } = string.Empty;

}
