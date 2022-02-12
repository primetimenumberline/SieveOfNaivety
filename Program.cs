int n = 101;
for (int i = 2; i <= n; i++)
{
    if (isPrime(i))
        Console.WriteLine(i);
}
bool isPrime(int i)
{
    for (int j = 2; j*j <= i; j++)
    {
        if ( mod(i,j) == 0 )
            return false;
    }
    return true;
}
int mod(int i, int j)
{
    int q = 1;
    int r = 0;
    while ( q * j <= i)
    {
        q++;
    }
    r = i - ((q - 1) * j);
    return r;
}