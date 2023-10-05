from src.abstractFactory import AbstractTaskFactory

class TodoListSingleton:
    _instance = None

    def __new__(cls):
        if not cls._instance:
            cls._instance = super(TodoListSingleton, cls).__new__(cls)
            cls._instance.tasks = []
        return cls._instance

    def add_task(self, task):
        self.tasks.append(task)

    def remove_task(self, task_name):
        self.tasks = [task for task in self.tasks if task.name != task_name]

    def display_tasks(self):
        for task in self.tasks:
            task.display()


