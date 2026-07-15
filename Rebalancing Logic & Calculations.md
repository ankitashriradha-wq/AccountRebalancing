Rebalancing Logic & Calculations
To get each security to zero target variance, the portfolio must be rebalanced so that:
Target Value = Target÷100 x 100,000
Current Value = Current÷100 x 100,000
"Difference"="Target Value"-"Current Value" 
"Shares to Buy/Sell"="Difference" /"Unit Price" 
Negative difference → buy 
Positive difference → sell (as stated in the document)
Negative (-ve) unit means you need to buy and Positive (+ve) unit means you need to sell
Rebalancing Calculations for each security (Test Scenarios)
IBM
	Target % = 20% → 20/100 x 10000= 20,000
	Current % = 10% → 10/100 x 10000 = 10,000
	Difference = +10,000 (need to buy)
	Price = 150
	Shares = 10,000 / 150 = 66.67 → 67 shares to buy
MSFT
	Target % = 20% → 20/100 x 10000= 20,000
	Current % = 20% → 20,000
	Difference = 0
	Shares = 0
ORCL
	Target % = 20% → 20/100 x 10000= 20,000
	Current % = 30% → 30/100 x 10000 = 30,000
	Difference = –10,000 (need to sell)
	Price = 220
	Shares = 10,000 / 220 = 45.45 → 45 shares to sell
AAPL
	Target % = 20%
	Current % = 20%
	Difference = 0
	Shares = 0
HD
	Target % = 20%
	Current % = 20%
	Difference = 0
	Shares = 0
Final Output — Shares to Buy/Sell 
Security	Buy/Sell	Shares
IBM	Buy	67
MSFT	None	0
ORCL	Sell	45
AAPL	None	0
HD	None	0


