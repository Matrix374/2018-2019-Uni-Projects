/*
* process-scheduling-test.c
*
* Author: Muhamad Irfan Hafiz bin Muhamad Hanafi
* Student ID: 17089640
*
*/

#include <stdlib.h>
#include <stdio.h>

int showMenu(void);
int getData(int);

void display(int[], int[], int[], int[], int, float, float);
void fcfs(void);
void sjf(void);
void rr(void);

void bubbleSort(int[], int[], int);
void swap(int*, int*);

int main(int argc, char **argv)
{

	int choice = 0;

	while(choice != 4){

        choice = showMenu();

		switch(choice)
		{
			case 1:
				fcfs();
				break;
			case 2:
				sjf();
				break;
			case 3:
				rr();
				break;
			case 4:
				choice = 4;
				break;
			default:
				choice = 0;
				break;
		}
	}

	exit(0);

	return 0;
}

/*
* Purpose: The purpose of this function is to separate the menu from the controller
          show the options the user has on which scheduler they can use
          and receive an input which it returns back to main
*
* Explanation:
*
* Returns: int choice - returns numbers 1-4 to the main
*
* Advantages: Modular design allows developers to work on separate aspects of code
              without accidentally affecting unrelated parts of the code.
              This also allows for cleaner and more readable code in the main module.
*/
int showMenu()
{
    int choice;

    printf("1 - First Come First Served (FCFS) Scheduler\n");
    printf("2 - Shortest Job First (SJF) Scheduler\n");
    printf("3 - Round Robin (RR) Scheduler\n");
    printf("4 - Quit\n");
    printf("Enter a Selection: ");
    scanf("%d", &choice);

    printf("\n");

    return choice;
}

/*
* Purpose: Returns a data set which consists of Arrival Time and Burst Time
*
* Explanation:
*
* Parameters: int choice - receives number 1-3 which determines which dataset is used
*
* Returns: int dataset - returns a dataset consisting of Arrival Time and Burst Time
*
*/
int getData(int choice)
{
    int dataset1[2][6] =
    {
        {0, 1, 2, 3, 4, 6}, //Arrival Time
        {3, 6, 8, 25, 5, 20} //Burst Time
    };
    int dataset2[2][6] =
    {
        {0, 1, 2, 3, 4, 6}, //Arrival Time
        {25, 20, 3, 8, 6, 5} //Burst Time
    };
    int dataset3[2][6] =
    {
        {3, 1, 2, 0, 6, 8}, //Arrival Time
        {4, 5, 20, 25, 14, 6} //Burst Time
    };

    switch(choice)
    {
        case 1:
            return dataset1;
            break;
        case 2:
            return dataset2;
            break;
        case 3:
            return dataset3;
            break;
        default:
            printf("Dataset doesn't exist");
            break;
    }

    return 0;
}

/*
* Purpose: Since all schedulers uses the same variables, this function was made so that code
           repeated less and doesn't bloat the scheduler functions
*
* Explanation:
*
* Parameters: int at[] -
              int bt[] -
              int tat[] -
              int wt[] -
              int n -
              float atat -
              float awt -
*
*
* Advantages: Modular design allows developers to work on separate aspects of code
              without accidentally affecting unrelated parts of the code.
              This also allows for cleaner and more readable code in the main module.
*/
void display(int at[], int bt[], int tat[], int wt[], int n, float atat, float awt)
{

    int i;

    printf("\nAT\tBT\tTaT\tWT\n");

    for(i=0;i<n;i++)
    {
		printf("%3d\t%3d\t%3d\t%3d\n",at[i],bt[i],tat[i],wt[i]);
    }

    printf("Average Turn Around Time: %f\nAverage WaitTime:%f\n\n",atat,awt);
}

/*
* Purpose: First Come First Serve Scheduler
*
* Explanation:
*
* Advantages: Modular design allows developers to work on separate aspects of code
              without accidentally affecting unrelated parts of the code.
              This also allows for cleaner and more readable code in the main module.
*
* Disadvantages:
*
*/
void fcfs()
{
	printf("\nFirst Come First Serve\n");

	int wt[6]; //wait time
	int n = 6; //number of processes
	//int at[6] = {0, 1, 2, 3, 5, 6}; // Arrival time of all processes
	//int bt[6] = {4, 3, 1, 2, 5, 6}; // Burst time of all processes

    int at[6] = {3, 1, 2, 0, 6, 8};
    int bt[6] = {4, 5, 20, 25, 14, 6};

    bubbleSort(at, bt, n);

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

    int btt=bt[0];//to store total burst time sum

    //Calculation
    int i;

    for(i=1;i<n;i++){
      wt[i]=btt-at[i];
      btt+=bt[i];
      awt+=wt[i];
      tat[i]= wt[i]+bt[i];
      atat+=tat[i];
    }

    atat/=n;
    awt/=n;

	display(at, bt, tat, wt, n, atat, awt);
}

/*
* Purpose: Shortest Job First
*
* Explanation:
*
* Advantages: Modular design allows developers to work on separate aspects of code
              without accidentally affecting unrelated parts of the code.
              This also allows for cleaner and more readable code in the main module.
*
* Disadvantages:
*
*/
void sjf()
{
	printf("\nShortest Job First\n");

	int wt[6]; //wait time
	int n = 6; //number of processes
	int at[6] = {3, 1, 2, 0, 6, 8};
    int bt[6] = {4, 5, 20, 25, 14, 6};

    bubbleSort(at, bt, n);

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

    int btt=bt[0];//to store total burst time sum

    //Calculation
    int i;

    for(i=1;i<n;i++){
      wt[i]=btt-at[i];
      btt+=bt[i];
      awt+=wt[i];
      tat[i]= wt[i]+bt[i];
      atat+=tat[i];
    }

    atat/=n;
    awt/=n;

	display(at, bt, tat, wt, n, atat, awt);
}

/*
* Purpose: Round Robin
*
* Explanation:
*
* Advantages: Modular design allows developers to work on separate aspects of code
              without accidentally affecting unrelated parts of the code.
              This also allows for cleaner and more readable code in the main module.
*
* Disadvantages:
*
*/
void rr()
{
	printf("\nRound Robin\n");

    int time = 0;
    int flag = 0;
    int timeQuantum, remain;

    int wt[6]; //wait time
	int n = 6; //number of processes

	remain = n;

	int at[6] = {3, 1, 2, 0, 6, 8};
    int bt[6] = {4, 5, 20, 25, 14, 6};

    bubbleSort(at, bt, n);

    int rt[6];

    for(int i = 0; i < n; i++)
    {
        rt[i] = bt[i];
    }

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

    int btt=bt[0];//to store total burst time sum

	printf("Input Time Quantum: ");
	scanf("%d", &timeQuantum);

    int i = 0;

	for(time = 0, i = 0; remain != 0;)
    {
        if(rt[i] <= timeQuantum && rt[i] > 0)
        {
            time += rt[i];
            rt[i] = 0;
            flag = 1;
        }
        else if(rt[i] > 0)
        {
            rt[i] -= timeQuantum;
            time += timeQuantum;
        }

        if(rt[i] == 0 && flag ==1)
        {
            remain--;

            wt[i] = time - at[i] - bt[i];
            awt += wt[i];
            tat[i] = time - at[i];
            atat += tat[i];

            flag = 0;
        }

        if(i == n - 1)
            i = 0;
        else if(at[i+1] <= time)
            i++;
        else
            i = 0;
    }


    atat/=n;
    awt/=n;

    display(at, bt, tat, wt, n, atat, awt);
}

//Sorts Arr1 based on Ascending Order
void bubbleSort(int arr1[], int arr2[], int n)
{
   int i, j;
   for (i = 0; i < n - 1; i++)
  {
      for (j = 0; j < n-i - 1; j++)
      {
         if (arr1[j] > arr1[j+1])
         {
            swap(&arr1[j], &arr1[j+1]);
            swap(&arr2[j], &arr2[j+1]);
         }
      }
  }
}

void swap(int *x, int *y)
{
    int temp = *x;
    *x = *y;
    *y = temp;
}


