// Q1. Hash-tables do not allow storing more than one value in a key. 
// How can we get around this restriction? Define a class to hold 
// multiple values in a hash-table.

// ans: You can use Dictionary<key, List<value>> or create your own 
// class ValuesCollection, which can take care of the values with the 
// same key and use Dictionary<key, ValuesCollection>.
