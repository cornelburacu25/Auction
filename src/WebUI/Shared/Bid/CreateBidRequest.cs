﻿using Cegeka.Auction.Domain.Enums;
using Cegeka.Auction.WebUI.Shared.Auction;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cegeka.Auction.WebUI.Shared.Bid
{
    public class CreateBidRequest
    {
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }

        public CreateBidRequest(BidDTO newBid)
        {
           Amount = newBid.Amount;
           CreatedAt = newBid.CreatedAt;   
        }
    }

    public class CreateBidRequestValidator
        : AbstractValidator<CreateBidRequest>
    {
        public CreateBidRequestValidator()
        {
            RuleFor(x => x.Amount)
                .NotEmpty();
        }
    }
}
