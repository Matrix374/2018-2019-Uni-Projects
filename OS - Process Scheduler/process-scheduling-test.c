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

void display(int[], int[], int[], int[], int, float, float);
void fcfs(int[], int[]);
void sjf(int[], int[]);
void rr(int[], int[]);

void calculate(int [], int [], int , int [], float , int [], float , int);
void bubbleSort(int[], int[], int);
void swap(int*, int*);

//dataset1
const int at1[6] = {0, 1, 2, 3, 4, 6}; //Arrival Time
const int bt1[6] = {3, 6, 8, 25, 5, 20}; //Burst Time
//dataset2
const int at2[6] = {0, 1, 2, 3, 4, 6}; //Arrival Time
const int bt2[6] = {25, 20, 3, 8, 6, 5}; //Burst Time
//dataset3
const int at3[6] = {3, 1, 2, 0, 6, 8}; //Arrival Time
const int bt3[6] ={4, 5, 20, 25, 14, 6}; //Burst Time

int main(int argc, char **argv)
{
    int *at[6];
    int *bt[6];

	int choice = 0;
    int dataChoice = 0;

	while(choice != 4){

        choice = showMenu();

        if(choice == 4)
        {
            break;
        }

        dataChoice = chooseData();

        if(dataChoice = 1)
        {
            int i, n = 6;
            for(i = 0; i < n; i++)
            {
                at[i] = at1[i];
                bt[i] = bt1[i];
            }
        }
        else if(dataChoice = 2)
        {
            int i, n = 6;
            for(i = 0; i < n; i++)
            {
                at[i] = at2[i];
                bt[i] = bt2[i];
            }
        }
        else if(dataChoice = 3)
        {
            int i, n = 6;
            for(i = 0; i < n; i++)
            {
                at[i] = at3[i];
                bt[i] = bt3[i];
            }
        }
        else
        {
            choice = 0;
            printf("Dataset Doesn't Exist\n");
        }

		switch(choice)
		{
			case 1:
				fcfs(at, bt);
				break;
			case 2:
				sjf(at, bt);
				break;
			case 3:
				rr(at, bt);
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
* Purpose: The purpose of this function is to separate the menu from the controller.
          Shows the options the user has on which scheduler they can use and receive an input which it returns back to main
*
*
* Returns: int choice - returns numbers 1-4 to the main
*
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
* Purpose: The purpose of this function is to separate the menu from the controller.
          Shows the options the user has on which scheduler they can use and receive an input which it returns back to main
*
*
* Returns: int choice - returns numbers 1-3 to the main
*
*/
int chooseData()
{
    int choice;

    printf("1 - Dataset 1\n");
    printf("2 - Dataset 2\n");
    printf("3 - Dataset 3\n");
    printf("Enter a Selection: ");
    scanf("%d", &choice);

    printf("\n");

    return choice;
}
/*
* Purpose: Since all schedulers uses the same variables, this function was made so that code
           repeated less and doesn't bloat the scheduler functions
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
              int tat[] - Turnaround Time
              int wt[] - Wait Time
              int n - Number of Processes
              float atat - Average Turnaround Time
              float awt - Average Wait Time
*
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
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages:
*
* Disadvantages:
*
*/
void fcfs(int at[], int bt[])
{
	printf("\nFirst Come First Serve\n");

	int wt[6]; //wait time
	int n = 6; //number of processes

    bubbleSort(at, bt, n);

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

    int btt=bt[0];//to store total burst time sum

    calculate(at, bt, btt, wt, awt, tat, atat, n);
}

/*
* Purpose: Shortest Job First Scheduler
*
* Explanation:
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages:
*
* Disadvantages:
*
*/
void sjf(int at[], int bt[])
{
	printf("\nShortest Job First\n");

	int wt[6]; //wait time
	int n = 6; //number of processes

    int temp_wt[6]; //temp wait time for sorting purposes

    bubbleSort(at, bt, n);
    int i;

    for (i = 1; i < n - 1; i++)
    {
        temp_wt[i] = at[i]+ bt[i];
        temp_wt[i+1] = at[i+1] + bt[i+1];

        if (temp_wt[i] > temp_wt[i+1])
        {
            swap(&at[i], &at[i+1]);
            swap(&bt[i], &bt[i+1]);
        }
    }

    //

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

    int btt=bt[0];//to store total burst time sum

    calculate(at, bt, btt, wt, awt, tat, atat, n);
}

/*
* Purpose: Round Robin Scheduler
*
* Explanation:
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages:
*
* Disadvantages:
*
*/
void rr(int at[], int bt[])
{
	printf("\nRound Robin\n");

    int time = 0;
    int flag = 0;
    int timeQuantum, remain;

    int wt[6]; //wait time
	int n = 6; //number of processes

	remain = n;

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

	while(remain != 0)
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
        else
            i++;
    }


    atat/=n;
    awt/=n;

    display(at, bt, tat, wt, n, atat, awt);
}

void calculate(int at[], int bt[], int btt, int wt[], float awt, int tat[], float atat, int n)
{
    int i;
    for(i=0; i < n; i++)
    {
        wt[i] = btt - at[i];
        btt += bt[i];
        awt += wt[i];
        tat[i] = wt[i] + bt[i];
        atat += tat[i];
    }

    atat /= n;
    awt /= n;

    display(at, bt, tat, wt, n, atat, awt);
}

/*
*Purpose: Sort datasets based on arrival time
*/
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
