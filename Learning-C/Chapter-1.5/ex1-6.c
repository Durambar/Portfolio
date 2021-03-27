#include <stdio.h>

/* count digits, white space, others */
int main(void)
{
    int c, i, j, nwhite, nother, current, count;
    int ndigit[10];

    count = current = nwhite = nother = 0;
    for(i = 0; i < 10; ++i)
        ndigit[i] = 0;
    
    while((c = getchar()) != EOF)
        if(c >= '0' && c <= '9')
            ++ndigit[c-'0'];
        else if(c == ' ' || c == '\n' || c == '\t')
            ++nwhite;
        else
            ++nother;
        
    printf("digits=");
    for(i = 0; i < 10; ++i)
        printf(" %d", ndigit[i]);
    printf(", white space = %d, other = %d\n", nwhite, nother);

    printf("\nHistogram\n");
    for(i = 0; i < 10; ++i){
        printf("%d |", i);
        if(ndigit[i] > 0){
            count = ndigit[i];
            while(count>0){
                putchar('*');
                --count;
            }
        }
        printf("\n");
    }
}