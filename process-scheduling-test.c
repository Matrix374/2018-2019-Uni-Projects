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
int chooseData(void);

void display(int[], int[], int[], int[], int, float, float);
void fcfs(int[], int[]);
void sjf(int[], int[]);
void rr(int[], int[]);

void calculate(int [], int [], int [], int , int [], float , int [], float , int);
void bubbleSort(int[], int[], int);
void swap(int*, int*);
void getData(int[], int[], int[], int[]);

//dataset1
int at1[6] = {0, 1, 2, 3, 4, 6}; //Arrival Time
int bt1[6] = {3, 6, 8, 25, 5, 20}; //Burst Time
//dataset2
int at2[6] = {0, 1, 2, 3, 4, 6}; //Arrival Time
int bt2[6] = {25, 20, 3, 8, 6, 5}; //Burst Time
//dataset3
int at3[6] = {3, 1, 2, 0, 6, 8}; //Arrival Time
int bt3[6] ={4, 5, 20, 25, 14, 6}; //Burst Time

int main(int argc, char **argv)
{
    int at[6];
    int bt[6];

	int choice = 0;
    int dataChoice = 0;

	while(choice != 4){

        choice = showMenu();

        if(choice == 4)
        {
            break;
        }

        dataChoice = chooseData();

        if(dataChoice == 1)
        {
			getData(at, bt, at1, bt1);
        }
        else if(dataChoice == 2)
        {
            getData(at, bt, at2, bt2);
        }
        else if(dataChoice == 3)
        {
            getData(at, bt, at3, bt3);
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
* Explanation:Receives Arrival Time and Burst Time and calculates the Wait Time, Turnaround Time, Average Wait Time and Average Turnaround Time
              based off which process arrives first
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages: Easy to implement and understand due to its simplicity
*
* Disadvantages: Not Efficient, will run processes until it finishes and is also based on Arrival Time so if shorter processes arrives later they will have to wait for longer processes to finish first
*
*/
void fcfs(int at[], int bt[])
{
	printf("\nFirst Come First Serve\n");

	int wt[6]; //wait time
	int ct[6]; //completion time
	int n = 6; //number of processes

    bubbleSort(at, bt, n);

	int tat[6]; //turn around time

	float awt = 0,atat = 0; //average wait time and average turn around time

	wt[0]=0;

    int ctt = 0;//completion time total

    calculate(at, bt, ct, ctt, wt, awt, tat, atat, n);
}

/*
* Purpose: Shortest Job First Scheduler
*
* Explanation:Receives Arrival Time and Burst Time and check if the immediate processes after the first one has a shorter burst time than the next one.
              If it is shorter it is swapped and ran first.
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages: Processes are done based on execution time, therefore easy and quick processes are finished first
*
* Disadvantages: When new processes are continually added, there is a chance for the program to continue working on shorter processes and ignore the longer processes
*
*/
void sjf(int at[], int bt[])
{
	printf("\nShortest Job First\n");

	int wt[6]; //wait time
	int ct[6]; //completion time
	int n = 6; //number of processes

    bubbleSort(at, bt, n);
    int i, j, k = 1;
    
    int bque = 0;
	
    for (i = 0; i < n; i++)
    {
		bque += bt[i];
		
		for(j = i + 1; j < n; j++)
		{

			if (bque > at[j] && bt[j] < bt[k])
			{
				swap(&at[j], &at[k]);
				swap(&bt[j], &bt[k]);
			}
		} 
		k++;
    }

	int tat[6]; //turn around time

	float awt = 0,atat = 0; //average wait time and average turn around time

	wt[0]=0;
    
    int ctt=0;//completion time total

    calculate(at, bt, ct, ctt, wt, awt, tat, atat, n);
}

/*
* Purpose: Round Robin Scheduler
*
* Explanation: Receives Arrival Time and Burst Time and spends a certain amount of time doing the work required based on the Time Quantum inputted.
               If a process's work is not finished within the Time Quantum, work is halted and is given to the next process in queue.
               Once a process is finished a flag is raised and it will calculate its Wait Time and Turnaround Time and removed from queue.
*
* Parameters: int at[] - Arrival Time
              int bt[] - Burst Time
*
* Advantages: All processes are given the same priority as they are given a fixed Time Quantum to work with.
*
* Disadvantages: The efficiency large depends on the length of Time Quantum,
* 				 If the Time Quantum is longer than needed, it behaves similarly to FCFS but if the Time Quantum is shorter, the CPU efficiency will decrease due to frequent CPU switches
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

    int rt[6]; //run time emulates burst time being run

    for(int i = 0; i < n; i++)
    {
        rt[i] = bt[i];
    }

	int tat[6]; //turn around time

	float awt,atat; //average wait time and average turn around time

	wt[0]=0;
    atat=tat[0]=bt[0];

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
/*
 * Purpose: FCFS and SJF uses the same calculations to calculate its' metrics so instead of repeating code I created a function
 *  
 * Explanation:
 * 
 * Inside The Loop:
	 * Completion Time Total += Burst Time[i]
	 * Completion Time[i] = Completion Time Total
	 * Turnaround Time[i] = Completion Time[i] - Arrival Time[i]
	 * Wait Time[i] = Turnaround Time[i] - Burst Time[i]
	 * Average Turnaround Time += Turnaround Time[i]
	 * Average Wait Time += Wait Time[i]
 * 
 * Average Turnaround Time /= Number of Processes
 * Average Wait Time /= Number of Processes
 * 
 * Parameters: int at[]
 * 			   int bt[]
 * 			   int ct[]
 *             int ctt[]
 *			   int wt[]
 *             float awt
 *             int tat[]
 *             float atat
 *             int n
 */
void calculate(int at[], int bt[], int ct[], int ctt, int wt[], float awt, int tat[], float atat, int n)
{
    int i;
    for(i=0; i < n; i++)
    {
        ctt += bt[i];
        ct[i] = ctt;
        tat[i] = ct[i] - at[i];
        wt[i] = tat[i] - bt[i];
        atat += tat[i];
        awt += wt[i];
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

/*
 * Purpose: Assignment of Arrival Time and Burst Time to datasets' values
 */
void getData(int at[], int bt[], int dataAT[], int dataBT[])
{
	int i, n = 6;
    for(i = 0; i < n; i++)
    {            
		at[i] = dataAT[i];
        bt[i] = dataBT[i];
    }
}
