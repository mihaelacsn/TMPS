from src.task import Task

class TaskEditor(Task):
    def __init__(self, name, status="Doing"):
        super().__init__(name, status)
        self.description = ""
        self.deadline = ""

    def add_description(self, description):
        self.description = description

    def set_deadline(self, deadline):
        self.deadline = deadline

    def display(self):
        print(f"Task: {self.name}, Status: {self.status}, Description: {self.description}")