public class ASum {
	
	public static long findNb(long m) {
		long i=1,suma=0;
    while(suma<m)
    {
      suma+=i*i*i;
      i++;
    }
    if(suma==m)
    return i-1;
    else
    return -1;
	}
	
}
