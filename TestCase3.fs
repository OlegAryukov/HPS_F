module TestCase3
let days_in_month = function 
    | 1|3|5|7|9|11 -> 31
    | 4|6|8|10|12 -> 30
    | 2 -> 28
    |_  -> 0

printf $"days in month 1 = {days_in_month 1}"
printf $"days in month 2 = {days_in_month 2}"
printf $"days in month 0 = {days_in_month 0}"