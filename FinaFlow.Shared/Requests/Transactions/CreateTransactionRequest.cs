﻿using System.ComponentModel.DataAnnotations;
using FinaFlow.Shared.Enums;

namespace FinaFlow.Shared.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Invalid title")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Invalid Type")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Invalid value")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Invalid category")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Invalid date")]
    public DateTime? PaidOrReceivedAt { get; set; }
}