#include <iostream>


void ave(){
    int aveg;
    int numbers[6] = {2,5,13,7,6,4};
    int sum = 0;
    for (int i = 0; i < 6;i++) {
        sum += numbers[i];
    }
    aveg = sum/6;
    std::cout << aveg << std::endl;
}

int main() {
ave();
return 0;
}
