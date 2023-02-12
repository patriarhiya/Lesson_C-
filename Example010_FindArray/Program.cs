int[] array = {1,2,34,4,4,5,69,7,8,9};
int n = array.Length;

int find = 4;
int i = 0;
while(i < n){

    if(array[i]==find){
        Console.WriteLine(i+1);
        break;
    }
    i++;
}