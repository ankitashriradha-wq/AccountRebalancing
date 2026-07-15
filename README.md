# AccountRebalancing Test Cases



These cases validate the core calculation logic in Rebalance Calculator and ensure correct handling of normal, boundary, and error conditions.
Test Case 1 — Buy Shares (Positive Difference)
Test Case ID: TC 01
Objective: Verify that the calculator returns the correct number of shares to buy when current allocation is below target.
Inputs:
•	Target % = 20
•	Current % = 10
•	Total Asset = 100,000
•	Price = 150
Steps:
1.	Calculate shares, Refer to Rebalancing Logic & Calculations sheet (20, 10, 100000, 150).
2.	Returned value should be equal to integer value and equal to expected value
Actual Result:
•	Target Value = 20,000
•	Current Value = 10,000
•	Difference = +10,000
•	Shares = 10,000 / 150 = 66.67 → 67
Pass Criteria:
Expected value = 67
--------------------------------------------------------------------------------------------------------------------------
Test Case 2 — No Action Needed (Zero Difference)
Test Case ID: TC 02
Objective: Validate that no shares are bought or sold when current % equals target %.
Inputs:
•	Target % = 20
•	Current % = 20
•	Total Asset = 100,000
•	Price = 90
Steps:
1.	Calculate, Refer to Rebalancing Logic & Calculations sheet (20, 20, 100000, 90).
2.	Returned value should be equal to expected value.
Actual Result:
•	Difference = 0
•	Shares = 0
Pass Criteria:
Expected value = 0
-------------------------------------------------------------------------------------------------------------------------
Test Case 3 — Sell Shares (Negative Difference)
Test Case ID: TC 03
Objective: Verify that the calculator returns a negative number when selling is required.
Inputs:
•	Target % = 20
•	Current % = 30
•	Total Asset = 100,000
•	Price = 220
Steps:
1.	Calculate shares, Refer to Rebalancing Logic & Calculations sheet (20, 30, 100000, 220).
2.	Returned value should be equal to expected value.
Actual Result:
•	Target Value = 20,000
•	Current Value = 30,000
•	Difference = –10,000
•	Shares = –10,000 / 220 = –45.45 → –45
Pass Criteria:
Expected value = –45
--------------------------------------------------------------------------------------------------------------------------
Test Case 4 — Invalid Price (Zero)
Test Case ID: TC 04
Objective: Ensure the method rejects invalid price values.
Inputs:
•	Target % = 20
•	Current % = 10
•	Total Asset = 100,000
•	Price = 0
Steps:
1.	Calculate, Refer to Rebalancing Logic & Calculations sheet (20, 10, 100000, 0).
2.	Observe the behaviour.
Actual Result:
•	Throws Exception with message “Price must be greater than zero.”
Pass Criteria: Expected Result
Exception is thrown with a message “Price must be greater than zero.”
-------------------------------------------------------------------------------------------------------------------------
Test Case 5 — Negative Target Percentage
Test Case ID: TC 05
Objective: Validate that negative percentages are rejected.
Inputs:
•	Target % = –10
•	Current % = 10
•	Total Asset = 100,000
•	Price = 100
Steps:
1.	Calculate, Refer to Rebalancing Logic & Calculations sheet (-10, 10, 100000, 100).
2.	Observe the behaviour.
Actual Result:
•	Throws Exception with a message (“Percentages must be non-negative”).
Pass Criteria: Expected result
Exception is thrown with a message “Percentages must be non-negative.”
-------------------------------------------------------------------------------------------------------------------------
Test Case 6 — Rounding Behaviour
Test Case ID: TC 06
Objective: Confirm rounding the value
Inputs:
•	Target % = 25
•	Current % = 23
•	Total Asset = 100,000
•	Price = 333
Steps:
1.	Calculate shares, Refer to Rebalancing Logic & Calculations sheet (25, 23, 100000, 333).
2.	Apply rounding rule (nearest whole number). 
Actual Result:
•	Difference = 2000
•	Shares = 2000 / 333 = 6.006 → 6
Pass Criteria:
Expected value = 6
--------------------------------------------------------------------------------------------------------------------------
Test Case 7 — Large Asset Values
Test Case ID: TC 07
Objective: Validate correct behaviour with large numbers.
Inputs:
•	Target % = 50
•	Current % = 40
•	Total Asset = 10,000,000
•	Price = 500
Steps:
1.	Calculate Shares, Refer to Rebalancing Logic & Calculations sheet (50, 40, 10000000, 500).
2.	Capture the returned value.
Actual Result:
•	Difference = 1,000,000
•	Shares = 1,000,000 / 500 = 2000
Pass Criteria:
Expected value = 2000
--------------------------------------------------------------------------------------------------------------------------
Test Case 9 — Both Percentages Zero
Test Case ID: TC 09
Objective: Validate behaviour when both target and current are zero.
Inputs:
•	Target % = 0
•	Current % = 0
•	Total Asset = 100,000
•	Price = 100
Steps:
1.	Calculate Shares, Refer to Rebalancing Logic & Calculations sheet (0, 0, 100000, 100).
2.	Capture the returned value.
Actual Result:
•	Difference = 0
•	Shares = 0
Pass Criteria: 
Expected value = 0
-------------------------------------------------------------------------------------------------------------------------
Test Case 10 — Floating Point Precision
Test Case ID: TC 10
Objective: Ensure floating point math does not cause rounding errors.
Inputs:
•	Target % = 33.33
•	Current % = 33.32
•	Total Asset = 100,000
•	Price = 123.45
Steps:
1.	Calculate Shares, Refer to Rebalancing Logic & Calculations sheet (33.33, 33.32, 100000, 123.45).
2.	Apply rounding rule (nearest whole number). 
Actual Result:
•	Difference = 1
•	Shares = 1 / 123.45 ≈ 0.008 → 0
Pass Criteria:
Expected value = 0
