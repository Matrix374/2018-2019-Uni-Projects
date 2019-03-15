/*
 * process-scheduling-test.c
 *
 * Author: Muhamad Irfan Hafiz bin Muhamad Hanafi
 * Purpose: To see the performance of different Process Scheduling methods
 *
 * Parameters: int choice : Gets input from user which decides which process scheduler to use or if they want to exit
 *
 * Stuff To Be Completed: SJF, RR
 * Completed: FCFS
 *
 */

#include <stdlib.h>
#include <stdio.h>

void display(int[], int[], int[], int[], int, float, float);
void fcfs(void);
void sjf(void);
void rr(void);

int main(int argc, char **argv)
{

	int choice = 0;


	while(choice != 4){
        printf("1 - First Come First Served (FCFS) Scheduler\n");
        printf("2 - Shortest Job First (SJF) Scheduler\n");
        printf("3 - Round Robin (RR) Scheduler\n");
        printf("4 - Quit\n");
        printf("Enter a Selection: ");
        scanf("%d", &choice);

        printf("\n");

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

//Display Performance Metrics
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

//First Come First Serve
void fcfs()
{
	printf("\nFCFS");

	int wt[10]; //wait time
	int n =5; //number of processes
	int at[10] = {0,1,2,3,5}; // Arrival time of all processes
	int bt[10] = {4,3,1,2,5}; // Burst time of all processes

	int tat[10]; //turn around time

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

//Shortest Job First
void sjf()
{
	printf("\nSJF\n");
}

//Round Robin
void rr()
{
	printf("\nRR\n");
}

