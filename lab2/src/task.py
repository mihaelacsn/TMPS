class Task:
    def __init__(self, name, status="Doing"):
        self.name = name
        self.status = status

    def display(self):
        print(f"Task: {self.name}, Status: {self.status}")
