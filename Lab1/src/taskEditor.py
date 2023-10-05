from src.task import Task
from src.abstractTask import AbstractTask

class TaskEditor(Task, AbstractTask):
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

    def mark_complete(self):
        self.status = "Done"
        print(f"Task '{self.name}' marked as complete.")