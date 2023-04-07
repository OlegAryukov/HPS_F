let days_in_month = function 
    | 1|3|5|7|9|11 -> 31
    | 2|4|6|8|10|12 -> 30
    |_  -> 0
