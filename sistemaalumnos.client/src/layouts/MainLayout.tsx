import Navigation from "../components/Navigation";

interface MainLayoutProps {
  text: string;
  children: React.ReactNode;
}

function MainLayout({ text, children }: MainLayoutProps) {
  return (
    <>
      <div>
        <h1 className="text-3xl font-bold  p-4 border-b-2">{text}</h1>
      </div>
      <div className="flex">

      <Navigation />
      <main>{children}</main>
      </div>
    </>
  );
}

export default MainLayout;
