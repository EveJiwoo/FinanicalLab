# Finanical Lab

https://www.filaboratory.com/

Fi-lab is created by group of high school students concerned about lack of financial education in school. Fi-lab wants students to engage early in financial education through the game and help make better decisions in real life. Students contribute with their talents and my role was to develop financial concept and apply in Unity. 




https://github.com/EveJiwoo/FinanicalLab/assets/145739444/72533f01-2f56-43ac-b316-879dc2057314


## Algorithm for saving & loan

When we tried to apply the concept of savings into the game, we wanted to make a variable interest rate. To apply this, we were challenged on how to provide this variable rate. So we started to study CPI, inflation, base rate and how banks set their interest rates. 

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/c0289ab7-7a0a-49af-a764-f974535498d8">
</p>

First, we decided that saving and loans are universal on the entire map of the game, meaning all banks share the same information, interest rate, and such. An axiom of rules further defined is as it follows: (1) When loan is taken, the user pays via a direct visit to the bank, (2) If the loan is not paid, the user will be put into cases, events of consequences from 1-8 weeks, (3) To make loans, the concept of credit and how much the user can lend is introduced, (4) Credit score changes on certain conditions

Using data from the US CPI of 1900’s to the current year, we made artificial CPI changes that mimic real situations. Then the base rate is applied according to the CPI and bank interest rate. Our goal is to let fellow young gamers experience the ups and downs of the economy. Aged people experience the economy through their life and gain wisdom and knowledge. We want teenagers to understand the importance of saving and spending less when loan rate is high. 

So our society will have more people with healthy financial positions later on in their life. 


## Using CPI for game play

I decided to study the relationship of changes in purchasing trends. I gathered that inflation changed the value of money, representing how much more expensive the relevant item in the game has become over a certain period. 

I wanted to apply realistic numbers in the game to accurately depict inflation in the user’s interaction with the game, that is why I chose to use CPI data of the U.S. Bureau of Labor Statistics––general between January 1977 and January 2023. I believed that CPI––the measure of inflation––was a key way to measure changes in purchasing trends and inflation.

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/6d2414ca-f1d8-449f-9d07-ca5eae86a587">
</p>

The CPI formula is: 

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/9706af56-e20d-4097-acd4-5beeaf9efeb2" width="70%">
</p>

When estimating the changes in item prices of the game, setting the cost of product in a previous time period as variable equaling $100, such formula was then utilized:
(CPI of a current periodCPI of a previous time period)*Cost of product in a previous time period = Cost of product in a current period

The results from the formula are based on the CPI data that we described above and represent our best estimate. 

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/a737bbd8-f995-4495-ac1c-227dc91dd14d" width="70%">
</p>

While developing this dataset for the game, I furthermore delved into the complexity of Macro world, fascinated to provide the most realistic yet manageable economy with a sound monetary set of rules for the users to experience. 

## Using CPI data to create mock base rate

I observed that interest rate and inflation were highly correlated, tending to move in the same direction––increasing and decreasing in similar time periods. With this theory, we based our inflation rate, created with CPI data, to model our mock interest rate. 

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/54ab559d-eb35-449c-985c-f97004c15f25" width="70%">
</p>


The inflation formula is: 

<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/4776fb7a-953c-4df2-a199-33b3be6d97ad" width="70%">
</p>

Using the CPI data, we calculated the rate of inflation for each month over the span of 46 years, then multiplied by 1000 to convert into percentage value.

Double checking the calculated inflation rate, I found that some values didn’t make sense logically to directly assimilate it into a mock interest rate. For example, a few inflation rates were negative. Thus, I created a few variations of my own, founded by logic (such as converting any negative value to 0%).


<p align ="center">
  <img src="https://github.com/EveJiwoo/FinanicalLab/assets/145739444/106535b8-635d-4ab6-94e6-ebc6740275b8" width="70%">
</p>

For example, a few inflation rates were below 0 and we also made changes to make it a positive number. 
