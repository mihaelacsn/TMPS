from src.task import Task
from src.todoList import TodoList
from src.taskEditor import TaskEditor
from src.interface import UserInterface

def main():
    todo_list = TodoList()
    ui = UserInterface()

    while True:
        print("\n--Options--:")
        print("1. Add Task")
        print("2. Remove Task")
        print("3. Mark Task as Complete")
        print("4. Display Tasks")
        print("5. Exit")

        choice = input("Enter your choice (1-5): ")

        if choice == "1":
            name = input("Enter task name: ")
            new_task = TaskEditor(name)
            new_task.add_description(input("Enter task description: "))
            new_task.set_deadline(input("Enter task deadline: "))
            todo_list.add_task(new_task)
            print(f"Task '{name}' added.")

        elif choice == "2":
            name_to_remove = input("Enter the name of the task to remove: ")
            todo_list.remove_task(name_to_remove)
            print(f"Task '{name_to_remove}' removed.")

        elif choice == "3":
            name_to_complete = input("Enter the name of the task to mark as complete: ")
            todo_list.mark_complete(name_to_complete)

        elif choice == "4":
            print("\nCurrent Tasks:")
            ui.display_message("\nCurrent Tasks:")
            todo_list.display_tasks()

        elif choice == "5":
            print("Exiting the program...")
            break

        else:
            print("Invalid choice.")

if __name__ == "__main__":
    main()
