﻿using DotLiquid;

namespace Grand.Core.Domain.Messages
{
    public class LiquidObject
    {
        public Drop AttributeCombination { get; set; }

        public Drop Auction { get; set; }

        public Drop BackInStockSubscription { get; set; }

        public Drop BlogComment { get; set; }

        public Drop Customer { get; set; }

        public Drop Forum { get; set; }

        public Drop GiftCard { get; set; }

        public Drop Knowledgebase { get; set; }

        public Drop NewsComment { get; set; }

        public Drop NewsletterSubscription { get; set; }

        public Drop Order { get; set; }

        public Drop PrivateMessage { get; set; }

        public Drop Product { get; set; }

        public Drop ProductReview { get; set; }

        public Drop RecurringPayment { get; set; }

        public Drop ReturnRequest { get; set; }

        public Drop Shipment { get; set; }

        public Drop ShoppingCart { get; set; }

        public Drop Store { get; set; }

        public Drop Vendor { get; set; }

        public Drop VendorReview { get; set; }

        public Drop EmailAFriend { get; set; }

        public Drop AskAQuestion { get; set; }

        public Drop VatValidationResult { get; set; }

        public Drop ContactUs { get; set; }
    }
}