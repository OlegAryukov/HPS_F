let days_in_month = function 
    | 1|3|5|7|9|11 -> 31
    | 4|6|8|10|12 -> 30
    | 2 -> 28
    |_  -> 0
   