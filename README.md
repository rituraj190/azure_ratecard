# azure_ratecard
This is the library which provide access over Azure Rate Card API

![Build Status](https://travis-ci.org/rituraj190/azure_ratecard.svg?branch=master)


# Getting Started

## Get the token

To get the token, firstly create instance of RateCardApIWrapper, then call method GetToken();

```c#
	using azure_ratecard;
	string clientId="";
	string clientSecret="";
    RateCardApIWrapper azureRateCard = new RateCardApIWrapper(clientId,clientSecret);
    var token = azureRateCard.GetToken();
            
```