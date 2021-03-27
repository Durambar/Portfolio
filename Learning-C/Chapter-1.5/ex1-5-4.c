#include <stdio.h>

#define IN 1    // inside a word
#define OUT 0   // outside a word

/* count lines, words and chatacyers in input */
int main(void)
{
    int c, nl, nw, nc, state;
    state = OUT;
    nl = nw = nc =0;

    while((c = getchar()) != EOF){
        ++nc;
        if(c == '\n')
            ++nl;
        if(c == ' ' || c == '\n' || c == '\t')
            state = OUT;
        else if(state == OUT){
            state = IN;
            ++nw;
        }
    }
    printf("New Line: %d\nNew Word: %d\nNew Char: %d\n", nl, nw, nc);
}