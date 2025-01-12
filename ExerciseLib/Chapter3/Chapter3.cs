int n = 39;
int v = 1;
int p = 4;

int bit = v << p;

n = n & (~bit);
n = n | bit;

Console.WriteLine(n);