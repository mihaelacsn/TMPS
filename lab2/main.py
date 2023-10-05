from src.todoList import TodoListSingleton
from src.factory import SimpleTaskFactory, EditorTaskFactory
from src.abstractFactory import SimpleTaskFactory as AbstractSimpleTaskFactory

class UserInterface:
    @staticmethod
    def get_user_input(prompt):
        return input(prompt)

    @staticmethod
    def display_message(message):
        print(message)

def main():
    TodoList = TodoListSingleton
    todo_list = TodoList()
    ui = UserInterface()

    task_factory = SimpleTaskFactory()

    while True:
        print("\nOptions:")
        print("1. Add Task")
        print("2. Remove Task")
        print("3. Display Tasks")
        print("4. Exit")

        choice = input("Enter your choice (1-4): ")

        if choice == "1":
            name = ui.get_user_input("Enter task name: ")
            task_type = ui.get_user_input("Enter task type (simple/editor): ")

            if task_type.lower() == "simple":
                task = task_factory.create_task(name)
            elif task_type.lower() == "editor":
                task = EditorTaskFactory().create_task(name)
            else:
                ui.display_message("Invalid task type. Supported types: simple, editor")
                continue

            todo_list.add_task(task)
            ui.display_message(f"Task '{name}' added.")

        elif choice == "2":
            task_name_to_remove = ui.get_user_input("Enter the name of the task to remove: ")
            todo_list.remove_task(task_name_to_remove)
            ui.display_message(f"Task '{task_name_to_remove}' removed.")


        elif choice == "3":
            ui.display_message("\nCurrent Tasks:")
            todo_list.display_tasks()

        elif choice == "4":
            ui.display_message("Exiting the program.")
            break

        else:
            ui.display_message("Invalid choice. Please enter a number between 1 and 4.")

if __name__ == "__main__":
    main()
