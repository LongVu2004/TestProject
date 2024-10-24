#include <stdio.h>

int main(){
	int num;
	printf("Nhap so nguyen co 3 chu so: ");
	scanf("%d",&num);
	if(num >= 100 && num <= 999){
		int sothu1 = num / 100;
		int sothu2 = (num % 100) / 10;
		int sothu3 = num / 10;
		int sodaonguoc = sothu3 * 100 + sothu2 * 10 + sothu1;
		printf("So dao nguoc cua so nguyen la: %d", sodaonguoc);
	} else {
		printf("Nhap so nguyen khong hop le!\n");
	}
	return 0;
}