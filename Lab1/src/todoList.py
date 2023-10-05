class TodoList:
    def __init__(self):
        self.tasks = []

    def add_task(self, task):
        self.tasks.append(task)

    def remove_task(self, task_name):
        self.tasks = [task for task in self.tasks if task.name != task_name]

    def display_tasks(self):
        for task in self.tasks:
            print(f"Task: {task.name}, Status: {task.status}")

    